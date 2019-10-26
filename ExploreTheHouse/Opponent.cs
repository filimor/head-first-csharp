using System;

namespace ExploreTheHouse
{
    public class Opponent
    {
        public Location MyLocation { get; }
        public Random Random { get; }

        public Opponent(Location location)
        {
            MyLocation = location;
            Random = new Random();
        }

        public void Move()
        {
            // Desloca o oponente de seu local atual pra um novo
            // Se ele estiver numa sala com uma porta, joga uma moeda pra ver se passa por ela:
            // Se Random.Next(2) for igual a 1 ele atravessa pela porta
            // Então ele escolher uma das saídas aleatoriamente e vai para lá
            // Se o lugar não tiver onde se esconder ele deve fazer isso de novo
        }

        public bool Check(Location location)
        {
            // Retorna true se o oponente está escondido lá
        }
    }
}
