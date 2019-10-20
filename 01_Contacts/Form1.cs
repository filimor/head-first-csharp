using System;
using System.Windows.Forms;

namespace Contacts
{
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }

        private void PicLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de Contatos" + Application.ProductVersion +
                "\nEscrito por: " + Application.CompanyName, "Sobre");
        }

        private void FrmContacts_Load(object sender, EventArgs e)
        {
        }
    }
}