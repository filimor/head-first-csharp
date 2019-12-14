using System.Drawing;

namespace SpaceInvaders
{
    public class Invader
    {
        /// <summary>
        /// Quantos pixels um invasor se move a cada vez que ele dá um passo.
        /// </summary>
        private const int HORIZONTALINTERVAL = 10;

        /// <summary>
        /// O número de pixels que um invasor desce quando a formação chega à borda do
        /// campo de batalha.
        /// </summary>
        private const int VERTICALINTERVAL = 40;

        private readonly Bitmap _image;

        public Point Location { get; private set; }
        public Type InvaderType { get; }
        public Rectangle Area => new Rectangle(Location, _image.Size);
        public int Score { get; }

        public enum Type
        {
            Bug,
            Saucer,
            Satellite,
            Spaceship,
            Star
        }

        public Invader(Type invaderType, Point location, int score)
        {
            InvaderType = invaderType;
            Location = location;
            Score = score;
            _image = InvaderImage(0);
        }

        /// <summary>
        /// Move a nave na direção especificada.
        /// </summary>
        /// <param name="direction">Direção do movimento.</param>
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    Location = new Point(Location.X + HORIZONTALINTERVAL, Location.Y);
                    break;

                case Direction.Left:
                    Location = new Point(Location.X - HORIZONTALINTERVAL, Location.Y);
                    break;

                case Direction.Down:
                    Location = new Point(Location.X, Location.Y + VERTICALINTERVAL);
                    break;
            }
        }

        /// <summary>
        /// Faz o invasor desenhar a si mesmo na área de jogo.
        /// </summary>
        /// <param name="g">Objeto Graphics.</param>
        /// <param name="animationCell">Célula de animação.</param>
        public void Draw(Graphics g, int animationCell)
        {
            g.DrawImage(InvaderImage(animationCell), Location);
        }

        /// <summary>
        /// Retorna o bitmap correto para a célula especificada.
        /// </summary>
        /// <param name="animationCell">Célula de animação.</param>
        /// <returns></returns>
        private Bitmap InvaderImage(int animationCell)
        {
            switch (InvaderType)
            {
                case Type.Bug:
                    switch (animationCell)
                    {
                        case 0:
                            return Resources.bug1;

                        case 1:
                            return Resources.bug2;

                        case 2:
                            return Resources.bug3;

                        case 3:
                            return Resources.bug4;
                    }
                    break;

                case Type.Satellite:
                    switch (animationCell)
                    {
                        case 0:
                            return Resources.satellite1;

                        case 1:
                            return Resources.satellite2;

                        case 2:
                            return Resources.satellite3;

                        case 3:
                            return Resources.satellite4;
                    }
                    break;

                case Type.Saucer:
                    switch (animationCell)
                    {
                        case 0:
                            return Resources.flyingsaucer1;

                        case 1:
                            return Resources.flyingsaucer2;

                        case 2:
                            return Resources.flyingsaucer3;

                        case 3:
                            return Resources.flyingsaucer4;
                    }
                    break;

                case Type.Spaceship:
                    switch (animationCell)
                    {
                        case 0:
                            return Resources.spaceship1;

                        case 1:
                            return Resources.spaceship2;

                        case 2:
                            return Resources.spaceship3;

                        case 3:
                            return Resources.spaceship4;
                    }
                    break;

                case Type.Star:
                    switch (animationCell)
                    {
                        case 0:
                            return Resources.star1;

                        case 1:
                            return Resources.star2;

                        case 2:
                            return Resources.star3;

                        case 3:
                            return Resources.star4;
                    }
                    break;
            }
            return null;
        }
    }
}