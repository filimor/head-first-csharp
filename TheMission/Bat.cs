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

            if (HitPoints >= 1)
            {
                Direction playerDirection = FindPlayerDirection(_game.PlayerLocation);
                if (random.Next(1) == 1)
                {
                    Move(playerDirection,_game.Boundaries);
                }
                else
                {
                    switch (random.Next(3))
                    {
                        case 1:
                            Move(Direction.Up, _game.Boundaries);
                            break;
                        case 2:
                            Move(Direction.Down, _game.Boundaries);
                            break;
                        case 3:
                            Move(Direction.Right, _game.Boundaries);
                            break;
                        case 4:
                            Move(Direction.Left, _game.Boundaries);
                            break;
                    }
                }
            }

            if (NearPlayer())
            {
                _game.HitPlayer(2,random);
            }
        }
    }
}