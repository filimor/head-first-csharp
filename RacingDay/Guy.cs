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

        public void UpdateLabels()
        {
            // Atribua ao meu rótulo a descrição da minha aposta, e ao rótulo do
            // meu botão de rádio o meu dinheiro ("João tem 43 reais")

            MyLabel.Text = MyBet != null ? $"{Name} apostou {MyBet.Amount} reais no cão número {MyBet.Dog}." : $"{Name} ainda não apostou";
            MyRadioButton.Text = $"{Name} tem {Cash} reais";
        }

        public void ClearBet()
        {
            // Reinicialize minha aposta para que ela zere
            MyBet = null;
        }

        public bool PlaceBet(int amount, int dog)
        {
            // Crie uma nova aposta e armazene-a no meu campo bet
            // Retorne verdadeiro se o cara tem dinheiro suficiente para apostar

            if (amount >= Cash)
            {
                MyBet = new Bet(amount, dog, this);
                return true;
            }
            return false;
        }

        public void Collect(int winner)
        {
            // Cobre minha aposta se eu ganhei
            // Chave: usar o objeto Bet

            Cash += MyBet.PayOut(winner);
        }
    }
}