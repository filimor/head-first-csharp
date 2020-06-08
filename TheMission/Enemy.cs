using System;
using System.Drawing;

namespace TheMission
{
    /// <summary>
    /// // Enemies não tem um método Attack() porque seu ataque foi incluído em Move().
    /// </summary>
    public abstract class Enemy : Mover
    {
        private const int NEARPLAYERDISTANCE = 25;

        public int HitPoints { get; private set; }

        /// <summary>
        /// O formulário usa-a para ver se o inimigo deve ser visível na masmorra do jogo.
        /// </summary>
        public bool Dead => HitPoints <= 0;

        /// <summary>
        /// Localização atual do inimigo.
        /// </summary>
        new public Point Location { get; set; }

        protected Enemy(Game game, Point location, Rectangle boundaries, int hitPoints) : base(game, location)
        {
            HitPoints = hitPoints;
        }

        /// <summary>
        /// Quando o jogador ataca um inimigo, ele chama o método Hit() de Enemy, que subtrai um
        /// número aleatório dos pontos de vida.
        /// </summary>
        /// <param name="maxDamage">Dano máximo.</param>
        /// <param name="random">Variável tipo aleatória.</param>
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public abstract void Move(Random random);

        /// <summary>
        /// Usa o método estático Mover.Nearby() para descobrir se o inimigo está perto do jogador.
        /// </summary>
        /// <returns>Retorna true se o inimigo está perto do jogador.</returns>
        protected bool NearPlayer()
        {
            return Nearby(_game.PlayerLocation, NEARPLAYERDISTANCE);
        }

        /// <summary>
        /// Descobre onde o jogador está em relação ao inimigo.
        /// </summary>
        /// <param name="playerLocation"></param>
        /// <returns>Retorna em qual direção o inimigo precisa se mover.</returns>
        protected Direction FindPlayerDirection(Point playerLocation)
        {
            return playerLocation.X > Location.X + 10
                ? Direction.Right : playerLocation.X < Location.X - 10
                ? Direction.Left : playerLocation.Y < Location.Y - 10
                ? Direction.Up : Direction.Down;
        }
    }
}