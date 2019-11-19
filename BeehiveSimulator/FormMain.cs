using System;
using System.Windows.Forms;

namespace BeehiveSimulator
{
    public partial class FormMain : Form
    {
        private World _world;

        public FormMain()
        {
            InitializeComponent();
            _world = new World();
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
            if (milliSeconds != 0.0)
            {
                lblFrameRate.Text = $"{1000 / milliSeconds:F0} ({milliSeconds:F1} ms";
            }
            else
            {
                lblFrameRate.Text = "N/A";
            }
        }
    }
}