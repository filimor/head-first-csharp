using System;
using System.Drawing;

namespace TheMission
{
    public abstract class Enemy : Mover
    {
        // Enemies não tem um método Attack() porque seu ataque
        // foi incluído em Move().

        private const int NEARPLAYERDISTANCE = 25;

        public int HitPoints { get; private set; }

        // O formulário pode usar essa propriedade para ver se o inimigo
        // deve ser visível na masmorra do jogo.
        public bool Dead => HitPoints <= 0;

        new public Point Location { get; private set; }

        protected Enemy(Game game, Point location, Rectangle boundaries, int hitPoints) : base(game, location)
        {
            HitPoints = hitPoints;
        }

        public void Hit(int maxDamage, Random random)
        {
            // Quando o jogador ataca um inimigo, ele chama o método Hit() de
            // Enemy, que subtrai um número aleatório dos pontos de vida.

            HitPoints -= random.Next(1, maxDamage);
        }

        public abstract void Move(Random random);

        protected bool NearPlayer()
        {
            // O método NearPlayer() usa o método estático Mover.Nearby()
            // para descobrir se o inimigo está perto do jogador.

            return Nearby(_game.PlayerLocation, NEARPLAYERDISTANCE);
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            // A partir da localização do jogador, usa o campo location
            // da classe base para descobrir onde o jogador está em relação
            // ao inimigo e retornará uma enum Direction que informa em qual
            // direção o inimigo precisa se mover para se aproximar do jogador.

            return playerLocation.X > Location.X + 10
                ? Direction.Right : playerLocation.X < Location.X - 10
                ? Direction.Left : playerLocation.Y < Location.Y - 10
                ? Direction.Up : Direction.Down;
        }
    }
}