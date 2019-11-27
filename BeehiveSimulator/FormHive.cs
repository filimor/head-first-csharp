using System.Windows.Forms;

namespace BeehiveSimulator
{
    public partial class FormHive : Form
    {
        public Renderer Renderer;

        public FormHive()
        {
            InitializeComponent();
            BackgroundImage = Renderer.ResizeImage(Properties.Resources.Hive__inside_,
                ClientRectangle.Width, ClientRectangle.Height);
        }

        private void FormHive_Paint(object sender, PaintEventArgs e)
        {
            Renderer.PaintHive(e.Graphics);
        }
    }
}