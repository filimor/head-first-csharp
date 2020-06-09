using System;
using System.IO;
using System.Windows.Forms;

namespace ExcuseManager
{
    public partial class FormExcuseManager : Form
    {
        private string _currentPath;
        private bool _formChanged;
        private Excuse _currentExcuse;
        private readonly Random _random = new Random();

        public FormExcuseManager()
        {
            InitializeComponent();
            _currentExcuse = new Excuse
            {
                Description = txtDescription.Text,
                Results = txtResults.Text,
                LastUsed = dtpLastUsed.Value
            };
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                txtDescription.Text = _currentExcuse.Description;
                txtResults.Text = _currentExcuse.Results;
                dtpLastUsed.Value = _currentExcuse.LastUsed;
                if (!string.IsNullOrEmpty(_currentExcuse.ExcusePath))
                {
                    lblFileDateDescription.Text = File.GetLastWriteTime(_currentExcuse.ExcusePath).ToString();
                }
                Text = "Gerenciador de Desculpas";
            }
            else
            {
                Text = "Gerenciador de Desculpas*";
            }
            _formChanged = changed;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = _currentPath;
            //saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|" +
            //    "Todos os Arquivos (*.*)|*.*";
            //saveFileDialog.FileName = txtDescription.Text + ".txt";
            saveFileDialog.Filter = "Arquivos de desculpa (*.excuse)|*.excuse|" +
                "Todos os Arquivos (*.*)|*.*";
            saveFileDialog.FileName = txtDescription.Text + ".excuse";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _currentExcuse.Save(saveFileDialog.FileName);
                MessageBox.Show("Desculpa Salva");
                UpdateForm(false);
            }
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = _currentPath;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK &&
                !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                btnSave.Enabled = true;
                btnOpen.Enabled = true;
                btnRandomExcuse.Enabled = true;
                _currentPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            _currentExcuse.Description = txtDescription.Text;
            UpdateForm(true);
        }

        private void TxtResults_TextChanged(object sender, EventArgs e)
        {
            _currentExcuse.Results = txtResults.Text;
            UpdateForm(true);
        }

        private void DtpLastUsed_ValueChanged(object sender, EventArgs e)
        {
            _currentExcuse.LastUsed = dtpLastUsed.Value;
            UpdateForm(true);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog.InitialDirectory = _currentPath;
                //saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|" +
                //    "Todos os Arquivos (*.*)|*.*";
                //saveFileDialog.FileName = txtDescription.Text + ".txt";
                saveFileDialog.Filter = "Arquivos de desculpa (*.excuse)|*.excuse|" +
                    "Todos os Arquivos (*.*)|*.*";
                saveFileDialog.FileName = txtDescription.Text + ".excuse";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _currentExcuse.OpenFile(openFileDialog.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void BtnRandomExcuse_Click(object sender, EventArgs e)
        {
            _currentExcuse = new Excuse(_random, _currentPath);
            UpdateForm(false);
        }

        private bool CheckChanged()
        {
            return !_formChanged || MessageBox.Show("A desculpa atual não foi salva. Deseja" +
                " continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                != DialogResult.No;
        }
    }
}