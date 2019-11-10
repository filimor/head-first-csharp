using System;
using System.Drawing;

namespace TheMission
{
    /// <summary>
    /// Weapon herda de Mover porque ela usa seus métodos Nearby() e Move() em DamageEnemy().
    /// </summary>
    public abstract class Weapon : Mover
    {
        protected Game game;

        /// <summary>
        /// Uma arma recolhida não deveria mais ser exibida. O formulário pode usar esse acessador get para descobrir isso.
        /// </summary>
        public bool PickedUp { get; private set; }

        /// <summary>
        /// Posição da arma na masmorra do jogo.
        /// </summary>
        new public Point Location { get; }

        // Cada classe de arma precisa implementar uma propriedade Name e
        // um método Attack() que determina como essa arma ataca.
        public abstract string Name { get; }

        protected Weapon(Game game, Point location):base(game,location)
        {
            this.game = game;
            Location = location;
            PickedUp = false;
        }

        /// <summary>
        /// Pega a arma e altera sua propriedade PickedUp para true.
        /// </summary>
        public void PickUpWeapon()
        {
            PickedUp = true;
        }

        // Cada arma possui um alcance e padrão de ataque próprios, e
        // por isso implementam o método Attack de forma diferente.
        public abstract void Attack(Direction direction, Random random);

        /// <summary>
        /// Chamado por Attack(). Tentar achar um inimigo em certa direção e raio. Se achar, chama o método Hit() do inimigo.
        /// </summary>
        /// <param name="direction">Direção a procurar o inimigo.</param>
        /// <param name="radius">Raio de procura.</param>
        /// <param name="damage">Dano causado.</param>
        /// <param name="random">Variável do tipo aleatória.</param>
        /// <returns>Retorna true se algum inimigo for encontrado.</returns>
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = _game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in _game.Enemies)
                {
                    //if (Nearby(enemy.Location, target, radius))
                    if (Nearby(target, radius))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                //target = Move(direction, target, _game.Boundaries);
                target = Move(direction, _game.Boundaries);
            }
            return false;
        }
    }
}