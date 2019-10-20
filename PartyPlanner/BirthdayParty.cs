using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    public class BirthdayParty
    {
        private int _numberOfPeople;
        private bool _fancyDecoration;
        private string _cakeWriting;
        private const int COSTOFFOODPERPERSON = 25;

        public decimal CostOfDecorations { get; private set; }
        public int CakeSize { get; private set; }
        public string CakeWriting {
            get => _cakeWriting;
            set
            {
                if((CakeSize==20 && value.Length> 16) ||
                    (CakeSize == 40 && value.Length > 40))
                {
                    MessageBox.Show($"Muitas letras para um bolo de {CakeSize} cm",
                        "Tamanho insuficiente", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }else{
                    _cakeWriting = value;
                }
            }
        }

        public int NumberOfPeople
        {
            get => _numberOfPeople;
            set
            {
                _numberOfPeople = value;
                CalculateCostOfDecorations(_fancyDecoration);
            }
        }

        public void CalculateCostOfDecorations(bool fancyDecoration)
        {
            CostOfDecorations = fancyDecoration ? 50M + (15M * NumberOfPeople) :
                30M + (7.5M * NumberOfPeople);
        }

        public decimal CalculateCost()
        {
            return (NumberOfPeople * COSTOFFOODPERPERSON) + CostOfDecorations + (CakeWriting.Length * 0.25M);
        }
    }
}
