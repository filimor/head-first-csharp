using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class FormPartyPlanner : Form
    {
        private DinnerParty dinnerParty;

        public FormPartyPlanner()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(5);
            dinnerParty.SetHealthyOption(chkHealthyOption.Checked);
            dinnerParty.CalculateCostOfDecorations(chkFancyDecoration.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            lblTotalCost.Text = dinnerParty.CalculateCost().ToString("c");
        }

        private void NudNumberOfPeople_ValueChanged(object sender, System.EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)nudNumberOfPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void ChkFancyDecoration_CheckedChanged(object sender, System.EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(chkFancyDecoration.Checked);
            DisplayDinnerPartyCost();
        }

        private void ChkHealthyOption_CheckedChanged(object sender, System.EventArgs e)
        {
            dinnerParty.SetHealthyOption(chkHealthyOption.Checked);
            DisplayDinnerPartyCost();
        }
    }
}