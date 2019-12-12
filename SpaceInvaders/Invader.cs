using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private Bitmap _image;

        public Point Location { get; private set; }
        public Type InvaderType { get; private set; }
        public Rectangle Area => new Rectangle(Location, _image.Size);
        public int Score { get; private set; }

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

        }

        /// <summary>
        /// Faz o invasor desenhar a si mesmo na área de jogo.
        /// </summary>
        /// <param name="g">Objeto Graphics.</param>
        /// <param name="animationCell">Célula de animação.</param>
        public void Draw(Graphics g, int animationCell)
        {
            InvaderImage(animationCell);
        }

        /// <summary>
        /// Retorna o bitmap correto para a célula especificada.
        /// </summary>
        /// <param name="animationCell">Célula de animação.</param>
        /// <returns></returns>
        private Bitmap InvaderImage(int animationCell)
        {
            return new Bitmap(100, 100);
        }
    }
}
