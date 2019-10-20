namespace PartyPlanner
{
    public class Party
    {
        private int _numberOfPeople;
        private bool _fancyDecoration;
        private const int COSTOFFOODPERPERSON = 25;

        public decimal CostOfDecorations { get; private set; }

        public virtual int NumberOfPeople
        {
            get => _numberOfPeople;
            set
            {
                _numberOfPeople = value;
                CalculateCostOfDecorations(_fancyDecoration);
            }
        }

        public Party(int numberOfPeople, bool fancyDecoration)
        {
            NumberOfPeople = numberOfPeople;
            _fancyDecoration = fancyDecoration;
            CalculateCostOfDecorations(_fancyDecoration);
        }

        public void CalculateCostOfDecorations(bool fancyDecoration)
        {
            _fancyDecoration = fancyDecoration;
            CostOfDecorations = fancyDecoration ? 50M + (15M * NumberOfPeople) :
                30M + (7.5M * NumberOfPeople);
        }

        public virtual decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + (COSTOFFOODPERPERSON * NumberOfPeople);
            if (NumberOfPeople > 12)
            {
                totalCost += 100M;
            }
            return totalCost;
        }
    }
}