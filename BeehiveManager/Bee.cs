namespace BeehiveManager
{
    public class Bee
    {
        public virtual int ShiftsLeft => 0;
        public int Weight { get; }

        public Bee(int weight)
        {
            Weight = weight;
        }

        public virtual double GetHoneyConsumption()
        {
            double consumption;
            if (ShiftsLeft == 0)
            {
                return 7.5;
            }

            consumption = 9.0 - ShiftsLeft;
            if (Weight > 150)
            {
                consumption *= 1.35;
            }
            return consumption;
        }
    }
}
