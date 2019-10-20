using System;
using System.Windows.Forms;

namespace RacingDay
{
    public partial class FormRacingDay : Form
    {
        private Guy[] guys = new Guy[3];
        private GreyHound[] greyHounds = new GreyHound[4];

        public FormRacingDay()
        {
            InitializeComponent();

            guys[0] = new Guy("João", 50, rdoJoao, lblJoao);
            guys[1] = new Guy("Beto", 75, rdoBeto, lblBeto);
            guys[2] = new Guy("Alfredo", 45, rdoAlfredo, lblAlfredo);

            int startPos = picRaceTrack.Left + 12;

            greyHounds[0] = new GreyHound(startPos, picRaceTrack.Width, picDog1);
            greyHounds[1] = new GreyHound(startPos, picRaceTrack.Width, picDog2);
            greyHounds[2] = new GreyHound(startPos, picRaceTrack.Width, picDog3);
            greyHounds[3] = new GreyHound(startPos, picRaceTrack.Width, picDog4);
        }

        private void BtnBet_Click(object sender, EventArgs e)
        {
            foreach (Guy guy in guys)
            {
                if (guy.MyRadioButton.Checked && !guy.PlaceBet((int)nudAmount.Value, (int)nudDog.Value))
                {
                    MessageBox.Show($"{guy.Name} não tem dinheiro o suficiente!", "Aposta não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                guy.UpdateLabels();
            }
        }

        private void RdoJoao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJoao.Checked)
            {
                lblBettor.Text = guys[0].Name;
            }
        }

        private void RdoBeto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBeto.Checked)
            {
                lblBettor.Text = guys[1].Name;
            }
        }

        private void RdoAlfredo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAlfredo.Checked)
            {
                lblBettor.Text = guys[2].Name;
            }
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (guys[0].MyBet.Amount == 0 && guys[1].MyBet.Amount == 0 && guys[2].MyBet.Amount == 0)
            {
                MessageBox.Show("Ninguém apostou!", "Sem apostadores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnRun.Enabled = false;
            btnBet.Enabled = false;
            int winner = 0;

            while (winner == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (greyHounds[i].Run())
                    {
                        winner = i + 1;
                        break;
                    }
                }
            }

            foreach (Guy bettor in guys)
            {
                bettor.Collect(winner);
                bettor.UpdateLabels();
            }

            MessageBox.Show($"O cão {winner} ganhou a corrida!", "Temos um vencedor!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRun.Enabled = true;
            btnBet.Enabled = true;

            foreach (GreyHound dog in greyHounds)
            {
                dog.TakeStartingPosition();
            }
        }
    }
}