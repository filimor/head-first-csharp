using System.Windows.Forms;

namespace BeehiveSimulator
{
    public partial class FormHive : Form
    {
        public FormHive()
        {
            InitializeComponent();
            BackgroundImage = Renderer.ResizeImage(Properties.Resources.Hive__inside_,
                ClientRectangle.Width, ClientRectangle.Height);
        }
    }
}