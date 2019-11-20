using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BeehiveSimulator
{
    [Serializable]
    public class Hive
    {
        private const int INITIALBEES = 6;
        private const double INITIALHONEY = 3.2;
        private const double MAXIMUMHONEY = 15.0;
        private const double NECTARTOHONEYRATIO = 0.25;
        private const int MAXIMUMBEES = 8;
        private const double MINIMUMHONEYFORCREATINGBEES = 4.0;

        private int _beeCount;
        private Dictionary<string, Point> _locations;
        private readonly World _world;

        public double Honey { get; private set; } = INITIALHONEY;

        public Bee.BeeMessage MessageSender;

        public Hive(Random random, World world,
            Bee.BeeMessage messageSender)
        {
            InitializeLocations();
            MessageSender = messageSender;
            random = new Random();
            _world = world;
            for (int i = 1; i <= INITIALBEES; i++)
            {
                AddBee(random);
            }
        }

        public void InitializeLocations()
        {
            _locations = new Dictionary<string, Point>
            {
                { "Entrance", new Point(600, 100) },
                { "Nursery", new Point(95, 174) },
                { "HoneyFactory", new Point(175, 98) },
                { "Exit", new Point(194, 213) }
            };
        }

        public bool AddHoney(double nectar)
        {
            double HoneyToAdd = nectar + NECTARTOHONEYRATIO;
            if (HoneyToAdd + Honey > MAXIMUMHONEY)
            {
                return false;
            }
            Honey += HoneyToAdd;
            return true;
        }

        public bool ConsumeHoney(double amount)
        {
            if (amount > Honey)
            {
                return false;
            }
            else
            {
                Honey -= amount;
                return true;
            }
        }

        private void AddBee(Random random)
        {
            _beeCount++;
            int r1 = random.Next(100) - 50;
            int r2 = random.Next(100) - 50;
            var startPoint = new Point(_locations["Nursery"].X + r1,
                _locations["Nursery"].Y + r2);
            var newBee = new Bee(_beeCount, startPoint, this, _world);
            newBee.MessageSender += MessageSender;
            _world.Bees.Add(newBee);
        }

        public void Go(Random random)
        {
            if (_world.Bees.Count < MAXIMUMBEES &&
                        Honey > MINIMUMHONEYFORCREATINGBEES &&
                        random.Next(10) == 1)
            {
                AddBee(random);
            }
        }

        public Point GetLocation(string location)
        {
            if (_locations.Keys.Contains(location))
            {
                return _locations[location];
            }
            throw new ArgumentException($"Local desconhecido: {location}");
        }
    }
}