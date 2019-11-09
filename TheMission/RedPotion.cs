using System;

namespace TheMission
{
    public class RedPotion : Weapon, IPotion
    {
        protected RedPotion(Game game, System.Drawing.Point location) : base(game, location)
        {
        }

        public override string Name => "Poção Vermelha";

        public bool Used { get; }

        public override void Attack(Direction direction, Random random)
        {
            // Aumenta a vida do jogadro em até 10 pontos chamando seu
            // método IncreasePlayerHealth(). Depois de usada, o método
            // Used() deve retornar true.
        }
    }
}