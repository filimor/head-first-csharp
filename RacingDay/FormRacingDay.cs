using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (rdoJoao.Checked){
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

        private void btnRun_Click(object sender, EventArgs e)
        {

        }
    }
}
