using System;
using System.Drawing;

namespace TheMission
{
    public sealed class Ghoul : Enemy
    {
        private Ghoul(Game game, Point location, Rectangle boundaries) :
            base(game, location, boundaries, 10)
        { }

        public override void Move(Random random)
        {
            // O zumbi é o inimigo mais difícil. Ele começa com 10 pontos de vida.
            // Quando pode se mover, há duas chances em três de que vá na direção
            // do jogador e uma em três de ficar parado. Se estiver perto do
            // jogador ele ataca com até 3 pontos de dano.
        }
    }
}