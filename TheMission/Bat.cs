using System;
using System.Drawing;

namespace TheMission
{
    public sealed class Bat : Enemy
    {
        public Bat(Game game, Point location, Rectangle boundaries) :
            base(game, location, boundaries, 6)
        { }

        public override void Move(Random random)
        {
            // O morcego começa com 6 pontos de vida. Ele continua se aproximando
            // do jogador e atacando, desde que tenha 1 ou mais pontos de vida.
            // Quando ele se move, existe uma chance de 50% de que seja na direção
            // do jogadr e 50% de que seja uma direção aleatória. Depois que o
            // morcego se moveu, ele checa se está perto do jogador - se estiver,
            // então ele ataca com até 2 pontos de dano.

            if (NearPlayer())
            {
                //_game.HitPlayer();
            }
        }
    }
}