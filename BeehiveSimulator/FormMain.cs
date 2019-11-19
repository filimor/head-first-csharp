using System;
using System.Windows.Forms;

namespace BeehiveSimulator
{
    public partial class FormMain : Form
    {
        private World _world;
        private Random _random = new Random();
        private DateTime _start = DateTime.Now;
        private DateTime _end;
        private int _framesRun;

        public FormMain()
        {
            InitializeComponent();
            _world = new World(new Bee.BeeMessage(SendMessage));
            tmrTimer.Interval = 50;
            tmrTimer.Tick += RunFrame;
            tmrTimer.Enabled = false;
            UpdateStats(new TimeSpan());
        }

        private void UpdateStats(TimeSpan frameDuration)
        {
            lblBees.Text = _world.Bees.Count.ToString();
            lblFlowers.Text = _world.Flowers.Count.ToString();
            lblHoneyInHive.Text = _world.Hive.Honey.ToString("F3");
            double nectar = 0;
            foreach (Flower flower in _world.Flowers)
            {
                nectar += flower.Nectar;
            }
            lblNectarInFlowers.Text = nectar.ToString("F3");
            lblFramesRun.Text = _framesRun.ToString();
            double milliSeconds = frameDuration.TotalMilliseconds;
            lblFrameRate.Text = milliSeconds != 0.0 ? $"{1000 / milliSeconds:F0} ({milliSeconds:F1} ms)" : "N/A";

            int beeFlying = 0;
            int beeGathering = 0;
            int beeMaking = 0;
            int beeReturning = 0;

            foreach (Bee bee in _world.Bees)
            {
                switch (bee.CurrentState)
                {
                    case BeeState.FlyingToFlower:
                        beeFlying++;
                        break;

                    case BeeState.GatheringNectar:
                        beeGathering++;
                        break;

                    case BeeState.MakingHoney:
                        beeMaking++;
                        break;

                    case BeeState.ReturningToHive:
                        beeReturning++;
                        break;
                }

                lstReport.Items.Clear();
                lstReport.Items.Add($"Voando para uma flor: {beeFlying}.");
                lstReport.Items.Add($"Recolhendo néctar: {beeGathering}.");
                lstReport.Items.Add($"Retornando para a colméia: {beeReturning}.");
                lstReport.Items.Add($"Fazendo mel: {beeMaking}.");
            }
        }

        private void SendMessage(int id, string message)
        {
            string status = string.Empty;
            switch (message)
            {
                case "Idle":
                    status = "Ociosa.";
                    break;

                case "FlyingToFlower":
                    status = "Voando para uma flor.";
                    break;

                case "GatheringNectar":
                    status = "Obtendo néctar.";
                    break;

                case "ReturningToHive":
                    status = "Retornando para a colméia.";
                    break;

                case "MakingHoney":
                    status = "Fabricando mel.";
                    break;

                case "Retired":
                    status = "Aposentada.";
                    break;
            }
            sslblSimulationStatus.Text = $"Abelha {id}: {status}";
        }

        private void RunFrame(object sender, EventArgs e)
        {
            _framesRun++;
            _world.Go(_random);
            _end = DateTime.Now;
            TimeSpan frameDuration = _end - _start;
            _start = _end;
            UpdateStats(frameDuration);
        }

        private void TsbtnStartSimulation_Click(object sender, EventArgs e)
        {
            if (!tmrTimer.Enabled)
            {
                tmrTimer.Start();
                tsbtnStartSimulation.Text = "Pausar Simulação";
                sslblSimulationStatus.Text = "Simulação em curso.";
            }
            else
            {
                tmrTimer.Stop();
                tsbtnStartSimulation.Text = "Recomeçar Simulação";
                sslblSimulationStatus.Text = "Simulação pausada.";
            }
        }

        private void TsbtnReset_Click(object sender, EventArgs e)
        {
            _world = new World(new Bee.BeeMessage(SendMessage));
            _framesRun = 0;
            if (!tmrTimer.Enabled)
            {
                tsbtnStartSimulation.Text = "Iniciar Simulação";
                sslblSimulationStatus.Text = "Simulação encerrada.";
            }
        }
    }
}