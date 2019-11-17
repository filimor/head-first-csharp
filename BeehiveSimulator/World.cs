using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            for (int i = 0; i < 10; i++)
            {
                AddFlower(random);
            }
        }

        public void Go(Random random)
        {
            Hive.Go(random);

            for (int i = Bees.Count-1; i>=0 ; i--)
            {
                Bee bee = Bees[i];
                bee.Go(random);
                if(bee.CurrentState == BeeState.Retired)
                {
                    Bees.Remove(bee);
                }
            }

            double totalNectarHarvested = 0;
            for (int i = Flowers.Count; i >= 0; i--)
            {
                Flower flower = Flowers[i];
                flower.Go();
                totalNectarHarvested += flower.NectarHarvested;
                if (!flower.Alive)
                {
                    Flowers.Remove(flower);
                }
            }

            if(totalNectarHarvested > NECTARHARVESTEDPERNEWFLOWER)
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
