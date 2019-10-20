namespace PartyPlanner
{
    public class DinnerParty
    {
        private int _numberOfPeople;
        private bool _fancyDecoration;

        private const int COSTOFFOODPERPERSON = 25;
        public decimal CostOfBeveragesPerPerson { get; private set; }
        public decimal CostOfDecorations { get; private set; }

        public int NumberOfPeople
        {
            get => _numberOfPeople;
            set
            {
                _numberOfPeople = value;
                CalculateCostOfDecorations(_fancyDecoration);
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecoration)
        {
            NumberOfPeople = numberOfPeople;
            _fancyDecoration = fancyDecoration;
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(_fancyDecoration);
        }

        public void SetHealthyOption(bool healthyOption)
        {
            CostOfBeveragesPerPerson = healthyOption ? 5M : 20M;
        }

        public void CalculateCostOfDecorations(bool fancyDecoration)
        {
            _fancyDecoration = fancyDecoration;
            CostOfDecorations = fancyDecoration ? 50M + (15M * NumberOfPeople) :
                30M + (7.5M * NumberOfPeople);
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = (NumberOfPeople * (COSTOFFOODPERPERSON + CostOfBeveragesPerPerson)) + CostOfDecorations;

            if (healthyOption)
            {
                totalCost *= 0.95M;
            }

            return totalCost;
        }
    }
}