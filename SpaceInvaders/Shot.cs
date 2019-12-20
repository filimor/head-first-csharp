using System.Drawing;

namespace SpaceInvaders
{
    public class Shot
    {
        // Esses valores podem ser alterados para tornar o jogo mais fácil ou mais difícil.
        private const int MOVEINTERVAL = 20;

        private const int WIDTH = 5;
        private const int HEIGHT = 15;
        private readonly Direction _direction;
        private Rectangle _boundaries;

        public Point Location { get; private set; }

        public Shot(Point location, Direction direction, Rectangle boundaries)
        {
            Location = location;
            _direction = direction;
            _boundaries = boundaries;
        }

        /// <summary>
        /// Desenha um pequeno retângulo amarelo que é o disparo.
        /// </summary>
        /// <param name="g">Objeto Graphics</param>
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Yellow, new Rectangle(Location, new Size(WIDTH, HEIGHT)));
        }

        /// <summary>
        /// Movimenta o tiro para cima ou para baixo e verifica se o tiro está dentro
        /// dos limites da tela.
        /// </summary>
        /// <param name="direction">Direção do tiro.</param>
        /// <returns>Retorna true se o tiro ainda estiver dentro dos limites do jogo.</returns>
        public bool Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Location = new Point(Location.X, Location.Y - MOVEINTERVAL);
                    break;

                case Direction.Down:
                    Location = new Point(Location.X, Location.Y + MOVEINTERVAL);
                    break;
            }
            return _boundaries.Contains(Location);
        }
    }
}