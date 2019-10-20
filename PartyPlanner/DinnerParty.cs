namespace PartyPlanner
{
    public class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson { get; private set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecoration) : base(numberOfPeople, fancyDecoration)
        {
            SetHealthyOption(healthyOption);
        }

        public void SetHealthyOption(bool healthyOption)
        {
            CostOfBeveragesPerPerson = healthyOption ? 5M : 20M;
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = base.CalculateCost()
                + (CostOfBeveragesPerPerson * NumberOfPeople);

            if (healthyOption)
            {
                totalCost *= 0.95M;
            }

            return totalCost;
        }
    }
}