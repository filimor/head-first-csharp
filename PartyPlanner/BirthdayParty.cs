using System.Windows.Forms;

namespace PartyPlanner
{
    public class BirthdayParty
    {
        private int _numberOfPeople;
        private readonly bool _fancyDecoration;
        private string _cakeWriting;
        private const int COSTOFFOODPERPERSON = 25;

        public decimal CostOfDecorations { get; private set; }
        public int CakeSize { get; private set; }

        public string CakeWriting
        {
            get => _cakeWriting;
            set
            {
                int maxLength = CakeSize == 20 ? 16 : 40;
                if (value.Length > maxLength)
                {
                    MessageBox.Show($"Muitas letras para um bolo de {CakeSize} cm", "Tamanho insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _cakeWriting = _cakeWriting.Substring(0, maxLength);
                }
                else
                {
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
                CalculateCakeSize();
                CalculateCostOfDecorations(_fancyDecoration);
                _cakeWriting = CakeWriting;
            }
        }

        public BirthdayParty(int numberOfPeople, string cakeWriting, bool fancyDecoration)
        {
            NumberOfPeople = numberOfPeople;
            _fancyDecoration = fancyDecoration;
            CalculateCakeSize();
            CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecoration);
        }

        private void CalculateCakeSize()
        {
            CakeSize = _numberOfPeople <= 4 ? 20 : 40;
        }

        public void CalculateCostOfDecorations(bool fancyDecoration)
        {
            CostOfDecorations = fancyDecoration ? 50M + (15M * NumberOfPeople) :
                30M + (7.5M * NumberOfPeople);
        }

        public decimal CalculateCost()
        {
            return (NumberOfPeople * COSTOFFOODPERPERSON) + CostOfDecorations + (CakeSize == 20 ? (CakeWriting.Length * 0.25M) + 40M : (CakeWriting.Length * 0.25M) + 75M);
        }
    }
}