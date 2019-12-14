using System;
using System.Drawing;

namespace SpaceInvaders
{
    public class PlayerShip
    {
        /// <summary>
        /// Quantos pixels a nave se move a cada vez que ele dá um passo.
        /// </summary>
        private const int HORIZONTALINTERVAL = 10;

        private readonly Bitmap _image = Resources.player;
        private int _deadShipHeight;
        private DateTime _dateTime;
        private bool _alive = true;

        public Point Location { get; private set; }
        public Rectangle Area => new Rectangle(Location, _image.Size);

        /// <summary>
        /// Quando a nave é atingida por um disparo, o jogo atribui false para sua
        /// propriedade Alive, impedindo os invasores de se moverem até que a nave
        /// reinicie e altere a propriedade para ture novamente.
        /// </summary>
        public bool Alive
        {
            get => _alive;
            set
            {
                _alive = value;
                _dateTime = DateTime.Now;
            }
        }

        // Usar o acessador set para dar a um campo privado do tipo DateTime o valor
        // DateTime.Now. A primeira coisa que o método Go() da nave deve fazer é usar
        // um TimeSpan para verificar se três segundos se passaram. Se ainda não for
        // o caso, continue executando a animação de esmagamento. Assim que transcorrerem,
        // modifique Alive de volta para true para que o jogo saiba que deve continuar.

        /// <summary>
        /// Desenha a nave do jogador na posição certa - a não ser que ele esteja morto.
        /// Nesse caso ele desenha uma animação da nave sendo esmagada pelo disparo.
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            if (Alive)
            {
                // Reinicie o campo _deadShipHeight da nave usando a propriedade Location.
                _deadShipHeight = Area.Height;
                g.DrawImage(Resources.player, Location);
            }
            else
            {
                // Usa o campo privado _deadShipHeight para animar a nave sendo lentamente
                // esmagada pelo tiro. Depois de três segundos morta, a propriedade Alive
                // deve ser alterada de volta para true.

                // Verifique o campo _deadShipHeight. Se ele for maior que zero, diminua
                // seu valolr em 1 e use DrawImage() para desenhar a nave um pouco mais
                // achatada.

                if (_deadShipHeight > 0)
                {
                    _deadShipHeight--;
                    g.DrawImage(Resources.player, Location.X, Location.Y, Area.Width, _deadShipHeight);
                }

                if (DateTime.Now.Subtract(_dateTime).Seconds == 3)
                {
                    Alive = true;
                }
            }
        }

        /// <summary>
        /// Move o jogador na direção correta.
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
            }
        }
    }
}