using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Contacts
{
    public partial class FormContacts : Form
    {
        public FormContacts()
        {
            InitializeComponent();
        }

        private void PicLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Application.ProductName} {Application.ProductVersion}" +
                $"\nEscrito por: {Application.CompanyName}", "Sobre",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormContacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDBDataSet.People' table. You can move, or remove it, as needed.
            peopleTableAdapter.Fill(contactDBDataSet.People);
            // TODO: This line of code loads data into the 'contactDBDataSet.People' table. You can move, or remove it, as needed.
            peopleTableAdapter.Fill(contactDBDataSet.People);
        }

        private void PeopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            peopleBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(contactDBDataSet);
        }
    }
}