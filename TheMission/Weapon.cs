using System;
using System.Drawing;

namespace TheMission
{
    public abstract class Weapon : Mover
    {
        // Weapon herda de Mover porque ela usa seus métodos
        // Nearby() e Move() em DamageEnemy().

        protected Game game;

        // Uma arma recolhida não deveria mais ser exibida. O formulário
        // pode usar esse acessador get para descobrir isso.
        public bool PickedUp { get; private set; }

        // Toda arma possui uma posição na masmorra do jogo.
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

        public void PickUpWeapon()
        {
            PickedUp = true;
        }

        // Cada arma possui um alcance e padrão de ataque próprios, e
        // por isso implementam o método Attack de forma diferente.
        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            // O método DamageEnemy() é chamado por Attack(). Ele tenta achar
            // um inimigo em uma certa direção e raio. Se ele achar, chama o
            // método Hit() do inimigo e retorna true. Se nenhum inimigo for
            // encontrado, ele retorna false.

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