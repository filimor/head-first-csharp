using System;
using System.Drawing;

namespace TheMission
{
    public abstract class Mover
    {
        /// <summary>
        /// Tamanho do passo do jogador ou inimigo.
        /// </summary>
        private const int MOVEINTERVAL = 10;

        protected Game _game;

        /// <summary>
        /// Localização do jogador ou inimigo.
        /// </summary>
        public virtual Point Location { get; private set; }

        /// <summary>
        /// Instâncias de Mover recebem como parâmetro o objeto Game e uma posição atual.
        /// </summary>
        /// <param name="game">Instância de Game</param>
        /// <param name="location">Posição atual.</param>
        protected Mover(Game game, Point location)
        {
            _game = game;
            Location = location;
        }

        /// <summary>
        /// Calcula se um dado ponto está a uma certa distânciado jogador ou inimigo.
        /// </summary>
        /// <param name="locationToCheck">Ponto a verificar.</param>
        /// <param name="distance">Raio de distância.</param>
        /// <returns>Retorna true se estiver dentro do raio especificado.</returns>
        public bool Nearby(Point locationToCheck, int distance)
        {
            return Math.Abs(Location.X - locationToCheck.X) < distance &&
                Math.Abs(Location.Y - locationToCheck.Y) < distance;
        }

        /// <summary>
        /// Calcula o ponto final do movimento e tenta mover-se um passo nessa direção.
        /// </summary>
        /// <param name="direction">Direção do movimento.</param>
        /// <param name="boundaries">Limites da masmorra.</param>
        /// <returns>Se conseguir, retorna o novo Point; se ultrapassar os limites, o Point original.</returns>
        public virtual Point Move(Direction direction, Rectangle boundaries)
        {
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
                    if (newLocation.Y + MOVEINTERVAL <= boundaries.Bottom)
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

            Location = newLocation;
            return Location;
        }
    }
}