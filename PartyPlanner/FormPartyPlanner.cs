using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class FormPartyPlanner : Form
    {
        private DinnerParty dinnerParty;

        public FormPartyPlanner()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)nudDinner.Value,
                chkHealthyOption.Checked, chkFancyDinner.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            lblDinnerCost.Text = dinnerParty.CalculateCost(chkHealthyOption.Checked).ToString("c");
        }

        private void NudNumberOfPeople_ValueChanged(object sender, System.EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)nudDinner.Value;
            DisplayDinnerPartyCost();
        }

        private void ChkFancyDecoration_CheckedChanged(object sender, System.EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(chkFancyDinner.Checked);
            DisplayDinnerPartyCost();
        }

        private void ChkHealthyOption_CheckedChanged(object sender, System.EventArgs e)
        {
            dinnerParty.SetHealthyOption(chkHealthyOption.Checked);
            DisplayDinnerPartyCost();
        }

        private void NudBirthday_ValueChanged(object sender, System.EventArgs e)
        {
            if((int)nudBirthday.Value <=4 && txtCakeWriting.TextLength > 16)
            {
                txtCakeWriting.Text = txtCakeWriting.Text.Substring(0, 16);
            }
        }
    }
}