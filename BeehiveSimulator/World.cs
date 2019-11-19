using System;
using System.Collections.Generic;
using System.Drawing;

namespace BeehiveSimulator
{
    public class World
    {
        private const double NECTARHARVESTEDPERNEWFLOWER = 50.0;
        private const int FIELDMINX = 15;
        private const int FIELDMINY = 177;
        private const int FIELDMAXX = 690;
        private const int FIELDMAXY = 290;

        public Hive Hive;
        public List<Bee> Bees = new List<Bee>();
        public List<Flower> Flowers = new List<Flower>();

        public World()
        {
            var random = new Random();
            Hive = new Hive(random, this);
            for (int i = 0; i < 10; i++)
            {
                AddFlower(random);
            }
        }

        public void Go(Random random)
        {
            Hive.Go(random);
            for (int i = Bees.Count - 1; i >= 0; i--)
            {
                Bees[i].Go(random);
                if (Bees[i].CurrentState == BeeState.Retired)
                {
                    Bees.Remove(Bees[i]);
                }
            }

            double totalNectarHarvested = 0;
            for (int i = Flowers.Count - 1; i >= 0; i--)
            {
                Flowers[i].Go();
                totalNectarHarvested += Flowers[i].NectarHarvested;
                if (!Flowers[i].Alive)
                {
                    Flowers.Remove(Flowers[i]);
                }
            }

            if (totalNectarHarvested > NECTARHARVESTEDPERNEWFLOWER)
            {
                foreach (Flower flower in Flowers)
                {
                    flower.NectarHarvested = 0;
                }
                AddFlower(random);
            }
        }

        private void AddFlower(Random random)
        {
            var location = new Point(random.Next(FIELDMINX, FIELDMAXX),
                random.Next(FIELDMINY, FIELDMAXY));
            Flowers.Add(new Flower(location, random));
        }
    }
}