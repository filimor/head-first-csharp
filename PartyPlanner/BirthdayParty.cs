using System.Windows.Forms;

namespace PartyPlanner
{
    public class BirthdayParty : Party
    {
        private string _cakeWriting;

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

        public override int NumberOfPeople
        {
            get => base.NumberOfPeople;
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                _cakeWriting = CakeWriting;
            }
        }

        public BirthdayParty(int numberOfPeople, string cakeWriting, bool fancyDecoration) : base(numberOfPeople, fancyDecoration)
        {
            CalculateCakeSize();
            CakeWriting = cakeWriting;
        }

        private void CalculateCakeSize()
        {
            CakeSize = NumberOfPeople <= 4 ? 20 : 40;
        }

        public override decimal CalculateCost()
        {
            return base.CalculateCost() + (CakeSize == 20 ? (CakeWriting.Length * 0.25M) + 40M : (CakeWriting.Length * 0.25M) + 75M);
        }
    }
}