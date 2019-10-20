using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class FormPartyPlanner : Form
    {
        private DinnerParty dinnerParty;
        private BirthdayParty birthdayParty;

        public FormPartyPlanner()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)nudDinner.Value,
                chkHealthyOption.Checked, chkFancyDinner.Checked);
            birthdayParty = new BirthdayParty((int)nudBirthday.Value,
                txtCakeWriting.Text, chkFancyBirthday.Checked);
            DisplayDinnerPartyCost();
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            lblDinnerCost.Text = dinnerParty.CalculateCost(chkHealthyOption.Checked).ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            txtCakeWriting.Text = birthdayParty.CakeWriting;
            lblBirthdayCost.Text = birthdayParty.CalculateCost().ToString("c");
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
            birthdayParty.NumberOfPeople = (int)nudBirthday.Value;
            birthdayParty.CakeWriting = txtCakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void ChkFancyBirthday_CheckedChanged(object sender, System.EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(chkFancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void TxtCakeWriting_TextChanged(object sender, System.EventArgs e)
        {
            birthdayParty.CakeWriting = txtCakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}