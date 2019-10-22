using System;
using System.Windows.Forms;

namespace BeehiveManager
{
    public partial class FormBeehiveManager : Form
    {
        private Queen _queen;

        public FormBeehiveManager()
        {
            InitializeComponent();

            var workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Coletar néctar", "Produção de mel" });
            workers[1] = new Worker(new string[] { "Cuidar dos ovos", "Ensinar às abelhas bebês" });
            workers[2] = new Worker(new string[] { "Manutenção da colméia", "Patrulha" });
            workers[3] = new Worker(new string[] { "Coletar néctar", "Produção de mel", "Cuidar dos ovos", "Ensinar às abelhas bebês", "Manutenção da colméia", "Patrulha" });
            _queen = new Queen(workers);
        }

        private void BtnNextShift_Click(object sender, EventArgs e)
        {
            _queen.WorkTheNextShift();
        }
    }
}