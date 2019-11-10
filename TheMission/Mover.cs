using System;
using System.Drawing;

namespace TheMission
{
    public abstract class Mover
    {
        private const int MOVEINTERVAL = 10;
        protected Game _game;

        protected Point Location { get; private set; }

        protected Mover(Game game, Point location)
        {
            // Instâncias de Mover recebem como parâmetro o objeto Game
            // e uma posição atual.

            _game = game;
            Location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            // Pega um ponto e calcula se ele está a uma certa distância do objeto.
            // Checa a distância de um Point em relação à posição atual do objeto.
            // Se eles estierem a uma distância - definida por distance - de cada um,
            // ele retorna true; senão, retorna false.

            return Math.Abs(Location.X - locationToCheck.X) < distance &&
                Math.Abs(Location.Y - locationToCheck.Y) < distance;
        }

        public virtual Point Move(Direction direction, Rectangle boundaries)
        {
            // Recebe uma direção, assim como os limites da masmorra, e calcula
            // onde seria o ponto final desse movimento.
            // Tenta move-se um passo em uma direção. Se conseguir, retorna o novo
            // Point. Se chegar em um dos limites, retorna o Point original.

            Point newLocation = Location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MOVEINTERVAL >= boundaries.Top)
                    {
                        newLocation.Y -= MOVEINTERVAL;
                    }
                    break;

                case Direction.Down:
                    if (newLocation.Y - MOVEINTERVAL <= boundaries.Bottom)
                    {
                        newLocation.Y += MOVEINTERVAL;
                    }
                    break;

                case Direction.Left:
                    if (newLocation.X - MOVEINTERVAL >= boundaries.Left)
                    {
                        newLocation.X -= MOVEINTERVAL;
                    }
                    break;

                case Direction.Right:
                    if (newLocation.X + MOVEINTERVAL <= boundaries.Right)
                    {
                        newLocation.X += MOVEINTERVAL;
                    }
                    break;
            }
            return newLocation;
        }
    }
}