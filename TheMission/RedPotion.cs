using System;
using System.Drawing;

namespace TheMission
{
    public class RedPotion : Weapon, IPotion
    {
        public override string Name => "Poção Vermelha";
        public bool Used { get; }

        protected RedPotion(Game game, Point location) : base(game, location)
        {
        }

        public override void Attack(Direction direction, Random random)
        {
            // Aumenta a vida do jogadro em até 10 pontos chamando seu
            // método IncreasePlayerHealth(). Depois de usada, o método
            // Used() deve retornar true.
        }
    }
}