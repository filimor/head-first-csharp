using RacingDay.Properties;
using System.Windows.Forms;

namespace RacingDay
{
    public class Guy
    {
        public string Name { get; }
        public Bet MyBet { get; private set; }
        public int Cash { get; private set; }
        public RadioButton MyRadioButton { get; }
        public Label MyLabel { get; }

        public Guy(string name, int cash, RadioButton myRadioButton, Label myLabel)
        {
            Name = name;
            Cash = cash;
            MyRadioButton = myRadioButton;
            MyLabel = myLabel;
            UpdateLabels();
        }

        /// <summary>
        /// Assign my bet description to my label, and my money to my radio button label ("John has
        /// 43 dollars").
        /// </summary>
        public void UpdateLabels()
        {
            if (MyBet == null)
            {
                MyBet = new Bet(0, 0, this);
            }
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = $"{Name} {Resources.has} {Cash} {Resources.dollars}.";
        }

        /// <summary>
        /// Reset my bet to zero.
        /// </summary>
        public void ClearBet()
        {
            MyBet = null;
        }

        /// <summary>
        /// Make a new bet and store it in my Bet field.
        /// </summary>
        /// <param name="amount">Amount to bet.</param>
        /// <param name="dog">Dog number to bet.</param>
        /// <returns>Return true if the guy has enough money to bet.</returns>
        public bool PlaceBet(int amount, int dog)
        {
            if (Cash >= amount)
            {
                ClearBet();
                MyBet = new Bet(amount, dog, this);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Charge my bet if I won. Key: use the Bet object.
        /// </summary>
        /// <param name="winner"></param>
        public void Collect(int winner)
        {
            Cash += MyBet.PayOut(winner);
        }
    }
}