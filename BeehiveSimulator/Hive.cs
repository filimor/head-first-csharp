using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BeehiveSimulator
{
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

        public double Honey { get; private set; } = INITIALHONEY;
        

        public Hive(Random random)
        {
            InitializeLocations();
            random = new Random();
            for (int i = 1; i <= INITIALBEES; i++)
            {
                AddBee(random);
            }
        }

        public void InitializeLocations()
        {
            _locations = new Dictionary<string, Point>();
            _locations.Add("Entrance", new Point(600, 100));
            _locations.Add("Nursery", new Point(95, 174));
            _locations.Add("HoneyFactory", new Point(175, 98));
            _locations.Add("Exit", new Point(194, 213));
        }

        public bool AddHoney(double nectar)
        {
            return true;
        }

        public bool ConsumeHoney(double amount)
        {
            return true;
        }

        public void AddBee(Random random)
        {
        }

        public void Go(Random random)
        {
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