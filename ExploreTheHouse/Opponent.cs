using System;

namespace ExploreTheHouse
{
    public class Opponent
    {
        public Location MyLocation { get; private set; }
        public Random Random { get; }

        public Opponent(Location startingLocation)
        {
            MyLocation = startingLocation;
            Random = new Random();
        }

        public void Move()
        {
            // Desloca o oponente de seu local atual pra um novo Se ele estiver numa sala com uma
            // porta, joga uma moeda pra ver se passa por ela: Se Random.Next(2) for igual a 1 ele
            // atravessa pela porta Então ele escolher uma das saídas aleatoriamente e vai para lá
            // Se o lugar não tiver onde se esconder ele deve fazer isso de novo

            if (MyLocation is IHasExteriorDoor)
            {
                var locationWithDoor = MyLocation as IHasExteriorDoor;
                if (Random.Next(2) == 1)
                {
                    MyLocation = locationWithDoor.DoorLocation;
                }

                bool hidden = false;
                while (!hidden)
                {
                    int rnd = Random.Next(0, MyLocation.Exits.Length);
                    MyLocation = MyLocation.Exits[rnd];
                    hidden = MyLocation is IHidingPlace;
                }
            }
        }

        public bool Check(Location locationToCheck)
        {
            // Retorna true se o oponente está escondido lá
            return MyLocation == locationToCheck;
        }
    }
}