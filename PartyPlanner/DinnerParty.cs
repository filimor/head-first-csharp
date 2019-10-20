namespace PartyPlanner
{
    public class DinnerParty
    {
        private const int COSTOFFOODPERPERSON = 25;
        public int NumberOfPeople { get; set; }
        public decimal CostOfBeveragesPerPerson { get; private set; }
        public decimal CostOfDecorations { get; private set; }
        public bool HealthtOption { get; private set; }

        public DinnerParty(int numberOfPeople)
        {
            NumberOfPeople = numberOfPeople;
        }

        public void SetHealthyOption(bool healthyOption)
        {
            HealthtOption = healthyOption;
            CostOfBeveragesPerPerson = HealthtOption ? 5M : 20M;
        }

        public void CalculateCostOfDecorations(bool fancyDecoration)
        {
            CostOfDecorations = fancyDecoration ? 50M + (15M * NumberOfPeople) :
                30M + (7.5M * NumberOfPeople);
        }

        public decimal CalculateCost()
        {
            decimal totalCost = (NumberOfPeople * (COSTOFFOODPERPERSON + CostOfBeveragesPerPerson)) + CostOfDecorations;

            if (HealthtOption)
            {
                totalCost *= 0.95M;
            }

            return totalCost;
        }
    }
}