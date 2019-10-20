using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingDay
{
    public class Guy
    {
        public string Name { get; set; }
        public Bet MyBet { get; set; }
        public int Cash { get; set; }
        public RadioButton MyRadioButton { get; set; }
        public Label MyLabel { get; set; }

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
        }

        public void ClearBet()
        {
            // Reinicialize minha aposta para que ela zere
        }

        public bool PlaceBet(int amount, int dog)
        {
            // Crie uma nova aposta e armazene-a no meu campo bet
            // Retorne verdadeiro se o cara tem dinheiro suficiente para apostar
        }

        public void Collect(int winner)
        {
            // Cobre minha aposta se eu ganhei
            // Chave: usar o objeto Bet
        }
    }
}
