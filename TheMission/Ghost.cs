﻿using System;
using System.Drawing;

namespace TheMission
{
    public sealed class Ghost : Enemy
    {
        public Ghost(Game game, Point location, Rectangle boundaries) :
            base(game, location, boundaries, 8)
        { }

        public override void Move(Random random)
        {
            // O fanasma é mais difícil de derrotar que o morcego. Ele começa com 8 pontos. Existe
            // uma chance em três que ele vá na direção do jogador e duas chances de permanecer
            // parado. Se estiver perto do jogador, ele ataca com até 3 pontos de dano.

            if (HitPoints >= 1)
            {
                Direction playerDirection = FindPlayerDirection(_game.PlayerLocation);
                if (random.Next(2) == 2)
                {
                    Location = Move(playerDirection, _game.Boundaries);
                }
            }

            if (NearPlayer())
            {
                _game.HitPlayer(3, random);
            }
        }
    }
}