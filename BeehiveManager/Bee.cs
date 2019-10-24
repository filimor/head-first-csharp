namespace BeehiveManager
{
    public class Bee
    {
        public virtual int ShiftsLeft => 0;
        public double Weight { get; }

        public Bee(double weight)
        {
            Weight = weight;
        }

        public virtual double GetHoneyConsumption()
        {
            double consumption = (ShiftsLeft == 0) ? 7.5 : 9.0 + ShiftsLeft;
            if (Weight > 150)
            {
                consumption *= 1.35;
            }
            return consumption;
        }
    }
}