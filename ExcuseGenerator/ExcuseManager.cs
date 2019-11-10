using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcuseManager
{
    public partial class FormExcuseManager : Form
    {
        private string _currentPath;
        private bool _formChanged;
        private Excuse _currentExcuse;
        private Random _random;

        public FormExcuseManager()
        {
            InitializeComponent();
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                txtExcuse.Text = _currentExcuse.Description;
                txtResults.Text = _currentExcuse.Results;
                dtpLastUsed.Value = _currentExcuse.LastUsed;
                if (!string.IsNullOrEmpty(_currentExcuse.ExcusePath))
                {
                    dtpLastUsed.Text = File.GetLastWriteTime(_currentExcuse.ExcusePath).ToString();   
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
            // Cada desculpa é salva num arquivo de texto separado.
            // A primeira linha do arquivo é uma desculpa, a segunda
            // é o resultado e a terceira é a dta quando foi usada
            // pela última vez (use o método ToString() de DateTimePicker()

            if(txtExcuse.Text?.Length == 0 || txtResults.Text?.Length == 0)
            {
                MessageBox.Show("Por favor, especifique uma desculpa e um resultado.",
                    "Impossível salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog.InitialDirectory = _currentPath;
            saveFileDialog.Filter = "Arquivo de Texto (*.txt)|*.txt|" +
                "Todos os Arquivos (*.*)|*.*";
            saveFileDialog.ShowDialog();
            if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
            {
                _currentExcuse.Save(saveFileDialog.FileName);
            }
            MessageBox.Show("Desculpa Salva");
            UpdateForm(false);
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.SelectedPath != string.Empty)
            {
                btnSave.Enabled = true;
                btnOpen.Enabled = true;
                btnRandomExcuse.Enabled = true;
            }
            else
            {
                _currentPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void TxtExcuse_TextChanged(object sender, EventArgs e)
        {
            UpdateForm(true);
        }

        private void TxtResults_TextChanged(object sender, EventArgs e)
        {
            UpdateForm(true);
        }

        private void DtpLastUsed_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm(true);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (_formChanged && MessageBox.Show("A desculpa atual não foi salva. Deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                == DialogResult.No)
            {
                return;
            }

            openFileDialog.InitialDirectory = _currentPath;
            openFileDialog.ShowDialog();
            if (!string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                _currentExcuse.OpenFile(openFileDialog.FileName);
            }
            UpdateForm(false);
        }

        private void BtnRandomExcuse_Click(object sender, EventArgs e)
        {
            if (_formChanged && MessageBox.Show("A desculpa atual não foi salva. Deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                == DialogResult.No)
            {
                return;
            }

            _currentExcuse = new Excuse(random);
            UpdateForm(false);
        }
    }
}
