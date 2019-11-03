using System;
using System.Windows.Forms;

namespace GoFish
{
    public partial class FormGoFish : Form
    {
        private Game _game;

        public FormGoFish()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpa e repovoa a caixa de listagem que ocntém a mão do jogador, e então atualiza as caixas de texto.
        /// </summary>
        private void UpdateForm()
        {
            lstHand.Items.Clear();
            foreach (string cardName in _game.PlayerCardNames)
            {
                lstHand.Items.Add(cardName);
            }
            txtBooks.Text = _game.DescribeBooks();
            txtProgress.Text += _game.DescribePlayerHands();
            txtProgress.SelectionStart = txtProgress.Text.Length;
            txtProgress.ScrollToCaret();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Por favor digite seu nome", "Impossível iniciar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _game = new Game(txtName.Text, new string[] { "Joe", "Bob" }, txtProgress);
            btnStart.Enabled = false;
            txtName.Enabled = false;
            btnAsk.Enabled = true;
            UpdateForm();
        }

        private void BtnAsk_Click(object sender, EventArgs e)
        {
            txtProgress.Text = string.Empty;
            if (lstHand.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor escolha uma carta", "Impossível jogar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_game.PlayOneRound(lstHand.SelectedIndex))
            {
                txtProgress.Text += $"O vencedor é... {_game.GetWinnerName()}";
                txtBooks.Text = _game.DescribeBooks();
                btnAsk.Enabled = false;
            }
            else
            {
                UpdateForm();
            }
        }
    }
}