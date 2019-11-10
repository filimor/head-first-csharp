using System;
using System.Drawing;

namespace TheMission
{
    public class RedPotion : Weapon, IPotion
    {
        private readonly Player _player;
        public override string Name => "Poção Vermelha";
        public bool Used { get; private set; }

        public RedPotion(Game game, Point location, Player player) : base(game, location)
        {
            _player = player;
        }

        public override void Attack(Direction direction, Random random)
        {
            // Aumenta a vida do jogador em até 10 pontos chamando seu
            // método IncreasePlayerHealth(). Depois de usada, o método
            // Used() deve retornar true.

            _player.IncreaseHealth(10, random);
            Used = true;
        }
    }
}