using System.Windows.Forms;

namespace BeehiveSimulator
{
    public partial class FormField : Form
    {
        public Renderer Renderer { get; set; }

        public FormField()
        {
            InitializeComponent();
        }

        private void FormField_Paint(object sender, PaintEventArgs e)
        {
            Renderer.PaintField(e.Graphics);
        }
    }
}