using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

namespace BeehiveSimulator
{
    [Serializable]
    public partial class FormMain : Form
    {
        private World _world;
        private Renderer _renderer;
        private Random _random = new Random();
        private DateTime _start = DateTime.Now;
        private DateTime _end;
        private int _framesRun;
        private BinaryFormatter _formatter;

        private FormHive _hiveForm = new FormHive();
        private FormField _fieldForm = new FormField();

        public FormMain()
        {
            InitializeComponent();
            _world = new World(new Bee.BeeMessage(SendMessage));
            tmrTimer.Interval = 50;
            tmrTimer.Tick += RunFrame;
            tmrTimer.Enabled = false;
            UpdateStats(new TimeSpan());
            MoveChildForms();
            _hiveForm.Show(this);
            _fieldForm.Show(this);
            ResetSimulator();
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
        }

        private void SendMessage(int id, BeeState message)
        {
            sslblSimulationStatus.Text = $"Abelha {id}: {message.GetDescription()}";

            IOrderedEnumerable<IGrouping<BeeState, Bee>> beeGroups =
                from bee in _world.Bees
                group bee by bee.CurrentState into beeGroup
                orderby beeGroup.Key
                select beeGroup;
            lstReport.Items.Clear();
            foreach (IGrouping<BeeState, Bee> group in beeGroups)
            {
                string s = group.Count() == 1 ? "" : "s";
                lstReport.Items.Add($"{group.Key.GetDescription()}: {group.Count()} abelha{s}");
                if (group.Key == BeeState.Idle
                    && group.Count() == _world.Bees.Count
                    && _framesRun > 0)
                {
                    lstReport.Items.Add("Simulação encerrada: todas as abelhas estão ociosas.");
                    tsbtnStartSimulation.Text = "Simulação encerrada";
                    sslblSimulationStatus.Text = "Simulação encerrada";
                    tmrTimer.Enabled = false;
                }
            }
        }

        private void RunFrame(object sender, EventArgs e)
        {
            _framesRun++;
            _world.Go(_random);
            _end = DateTime.Now;
            TimeSpan frameDuration = _end - _start;
            _start = _end;
            UpdateStats(frameDuration);
            _hiveForm.Invalidate();
            _fieldForm.Invalidate();
        }

        private void MoveChildForms()
        {
            _hiveForm.Location = new Point(Location.X + Width + 10, Location.Y);
            _fieldForm.Location = new Point(Location.X, Location.Y +
                Math.Max(Height, _hiveForm.Height) + 10);
        }

        private void ResetSimulator()
        {
            _world = new World(new Bee.BeeMessage(SendMessage));
            _renderer = new Renderer(_world, _hiveForm, _fieldForm);
            _framesRun = 0;
        }

        private void CreateRenderer()
        {
            _renderer = new Renderer(_world, _hiveForm, _fieldForm);
            _hiveForm.Renderer = _renderer;
            _fieldForm.Renderer = _renderer;
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
            CreateRenderer();
            ResetSimulator();
            if (!tmrTimer.Enabled)
            {
                tsbtnStartSimulation.Text = "Iniciar Simulação";
                sslblSimulationStatus.Text = "Simulação encerrada.";
            }
        }

        private void TsbtnSave_Click(object sender, EventArgs e)
        {
            bool enabled = tmrTimer.Enabled;
            if (enabled)
            {
                tmrTimer.Stop();
            }

            _world.Hive.MessageSender = null;
            foreach (Bee bee in _world.Bees)
            {
                bee.MessageSender = null;
            }

            if (sfdSaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _formatter = new BinaryFormatter();
                    using (Stream output = File.OpenWrite(sfdSaveFile.FileName))
                    {
                        _formatter.Serialize(output, _world);
                        _formatter.Serialize(output, _framesRun);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossível salvar o arquivo\n" + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _world.Hive.MessageSender = new Bee.BeeMessage(SendMessage);
            foreach (Bee bee in _world.Bees)
            {
                bee.MessageSender = new Bee.BeeMessage(SendMessage);
            }
            if (enabled)
            {
                tmrTimer.Start();
            }
        }

        private void TsbtnOpen_Click(object sender, EventArgs e)
        {
            World currentWorld = _world;
            int currentFramesRun = _framesRun;
            bool enabled = tmrTimer.Enabled;

            if (enabled)
            {
                tmrTimer.Stop();
            }

            if(ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _formatter = new BinaryFormatter();
                    using (Stream input = File.OpenRead(ofdOpenFile.FileName))
                    {
                        _world = (World)_formatter.Deserialize(input);
                        _framesRun = (int)_formatter.Deserialize(input);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossível abrir o arquivo\n" + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _world = currentWorld;
                    _framesRun = currentFramesRun;
                }
            }

            _world.Hive.MessageSender = new Bee.BeeMessage(SendMessage);
            foreach (Bee bee in _world.Bees)
            {
                bee.MessageSender = new Bee.BeeMessage(SendMessage);
            }
            if (enabled)
            {
                tmrTimer.Start();
            }
            CreateRenderer();
            _renderer = new Renderer(_world, _hiveForm, _fieldForm);
        }

        private void FormMain_Move(object sender, EventArgs e)
        {
            MoveChildForms();
        }

        private void TmrBees_Tick(object sender, EventArgs e)
        {
            _renderer.AnimateBees();
        }
    }
}