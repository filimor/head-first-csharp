using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace BeehiveSimulator
{
    public partial class FormMain : Form
    {
        private World _world;
        private Renderer _renderer;
        private readonly Random _random = new Random();
        private DateTime _start = DateTime.Now;
        private DateTime _end;
        private int _framesRun;
        private BinaryFormatter _formatter;
        private readonly FormHive _hiveForm = new FormHive();
        private readonly FormField _fieldForm = new FormField();

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

        private int PrintTableRow(Graphics printGraphics, int tableX, int tableWidth,
            int firstColumnX, int secondColumnX, int tableY, string firstColumn,
            string secondColumn)
        {
            var arial12 = new Font("Arial", 12);
            var stringSize = Size.Ceiling(printGraphics.MeasureString(firstColumn,
                arial12));
            tableY += 2;
            printGraphics.DrawString(firstColumn, arial12, Brushes.Black, firstColumnX,
                tableY);
            printGraphics.DrawString(secondColumn, arial12, Brushes.Black, secondColumnX,
                tableY);
            tableY += (int)stringSize.Height + 2;
            printGraphics.DrawLine(Pens.Black, tableX, tableY, tableX + tableWidth, tableY);
            arial12.Dispose();
            return tableY;
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

            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
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

        private void TsbtnPrint_Click(object sender, EventArgs e)
        {
            bool enabled = tmrTimer.Enabled;
            if (enabled)
            {
                tmrTimer.Stop();
            }

            var document = new PrintDocument();
            var preview = new PrintPreviewDialog
            {
                Document = document
            };
            document.PrintPage += PdcPrintDocument_PrintPage;
            preview.ShowDialog(this);

            if (enabled)
            {
                tmrTimer.Start();
            }
        }

        private void PdcPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Size stringSize;
            using (var arial24bold = new Font("Arial", 24, FontStyle.Bold))
            {
                stringSize = Size.Ceiling(g.MeasureString("Simulador de Colméia",
                    arial24bold));
                g.FillEllipse(Brushes.Gray, new Rectangle(e.MarginBounds.X + 2,
                    e.MarginBounds.Y + 2, stringSize.Width + 30, stringSize.Height + 30));
                g.FillEllipse(Brushes.Black, new Rectangle(e.MarginBounds.X,
                    e.MarginBounds.Y, stringSize.Width + 30, stringSize.Height + 30));
                g.DrawString("Simulador de Colméia", arial24bold, Brushes.Gray,
                    e.MarginBounds.X + 17, e.MarginBounds.Y + 17);
                g.DrawString("Simulador de Colméia", arial24bold, Brushes.White,
                    e.MarginBounds.X + 15, e.MarginBounds.Y + 15);
            }

            int tableX = e.MarginBounds.X + stringSize.Width + 50;
            int tableWidth = e.MarginBounds.X + e.MarginBounds.Width - tableX - 20;
            int firstColumnX = tableX + 2;
            int secondColumnX = tableX + (tableWidth / 2) + 5;
            int tableY = e.MarginBounds.Y;

            tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY,
                "Abelhas", lblBees.Text);
            tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY,
                "Flores", lblFlowers.Text);
            tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY,
                "Mel na Colméia", lblHoneyInHive.Text);
            tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY,
                "Néctar nas Flores", lblNectarInFlowers.Text);
            tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY,
                "Quadros Transcorridos", lblFramesRun.Text);
            tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY,
                "Taxa de Quadros", lblFrameRate.Text);
            g.DrawRectangle(Pens.Black, tableX, e.MarginBounds.Y, tableWidth, tableY - e.MarginBounds.Y);
            g.DrawLine(Pens.Black, secondColumnX, e.MarginBounds.Y, secondColumnX, tableY);

            using (var blackPen = new Pen(Brushes.Black, 2))
            using (var hiveBitmap = new Bitmap(_hiveForm.ClientSize.Width, _hiveForm.ClientSize.Height))
            using (var fieldBitmap = new Bitmap(_fieldForm.ClientSize.Width, _fieldForm.ClientSize.Height))
            {
                using (var hiveGraphics = Graphics.FromImage(hiveBitmap))
                {
                    _renderer.PaintHive(hiveGraphics);
                }

                int hiveWidth = e.MarginBounds.Width / 2;
                float ratio = hiveBitmap.Height / (float)hiveBitmap.Width;
                int hiveHeight = (int)(hiveWidth * ratio);
                int hiveX = e.MarginBounds.X + ((e.MarginBounds.Width - hiveWidth) / 2);
                int hiveY = e.MarginBounds.Height / 3;
                g.DrawImage(hiveBitmap, hiveX, hiveY, hiveWidth, hiveHeight);
                g.DrawRectangle(blackPen, hiveX, hiveY, hiveWidth, hiveHeight);
                using (var fieldGraphics = Graphics.FromImage(fieldBitmap))
                {
                    _renderer.PaintField(fieldGraphics);
                }
                int fieldWidth = e.MarginBounds.Width;
                ratio = fieldBitmap.Height / (float)fieldBitmap.Width;
                int fieldHeight = (int)(fieldWidth * ratio);
                int fieldX = e.MarginBounds.X;
                int fieldY = e.MarginBounds.Y + e.MarginBounds.Height - fieldHeight;
                g.DrawImage(fieldBitmap, fieldX, fieldY, fieldWidth, fieldHeight);
                g.DrawRectangle(blackPen, fieldX, fieldY, fieldWidth, fieldHeight);
            }
        }
    }
}