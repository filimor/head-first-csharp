using System;
using System.Drawing;

namespace TheMission
{
    public class BluePotion : Weapon, IPotion
    {
        private readonly Player _player;
        public override string Name => "Poção Azul";
        public bool Used { get; private set; }

        public BluePotion(Game game, Point location, Player player) : base(game, location)
        {
            _player = player;
        }

        public override void Attack(Direction direction, Random random)
        {
            // Aumenta a vida do jogador em até 5 pontos chamando seu
            // método IncreasePlayerHealth(). Depois de usada, o método
            // Used() deve retornar true.

            _player.IncreaseHealth(5, random);
            Used = true;
        }
    }
}