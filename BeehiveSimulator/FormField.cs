using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveSimulator
{
    public partial class FormField : Form
    {
        public Renderer Renderer;

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
