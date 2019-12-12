using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class FormInvaders : Form
    {
        // A tecla no índice 0 será sempre a mais recentemente pressionada.
        private List<Keys> _keysPressed = new List<Keys>();
        private Game _game;
        private bool _gameOver;
        private int _counter;
        private Graphics _g;
        private int _animationCell;

        public FormInvaders()
        {
            InitializeComponent();
            _game = new Game(DisplayRectangle);
            _g = CreateGraphics();
            _game.GameOver += FormInvaders_OnGameOver;
        }

        /// <summary>
        /// Mantem a animação, fazendo as estrelas piscarem e as imagens dos invasores
        /// mudarem de quadro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrAnimator_Tick(object sender, EventArgs e)
        {
            switch (_counter)
            {
                case 0:
                    _counter++;
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    _counter--;
                    break;
            }

            _game.Twinkle();
            Refresh();
        }

        /// <summary>
        /// Lida com o andamento do jogo (a marcha dos invasores para esquerda e direita, o
        /// movimento do jogador e os tiros dos jogadores e invasores).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrGame_Tick(object sender, EventArgs e)
        {
            if(_keysPressed.Count >= 1)
            {
                switch (_keysPressed[0])
                {
                    case Keys.Left:
                        _game.MovePlayer(Direction.Left);
                        break;
                    case Keys.Right:
                        _game.MovePlayer(Direction.Right);
                        break;
                }
            }
            _game.Go(); // Mantém o controle sobre o estado do jogo e avança um quadro.
        }

        private void FormInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }
            if (_gameOver)
            {
                if(e.KeyCode == Keys.S)
                {
                    // Aqui vai o código para reiniciar o jogo e resetar os timers.
                    return;
                }
            }
            if(e.KeyCode == Keys.Space)
            {
                _game.FireShot();
            }
            if (_keysPressed.Contains(e.KeyCode))
            {
                _keysPressed.Remove(e.KeyCode);
            }
            _keysPressed.Add(e.KeyCode);
            // Removendo a tecla a adicionando-a novamente, fazemos com que ela seja a última
            // (mais atual contida na lista.
        }

        private void FormInvaders_KeyUp(object sender, KeyEventArgs e)
        {
            if (_keysPressed.Contains(e.KeyCode))
            {
                _keysPressed.Remove(e.KeyCode);
            }
        }

        private void FormInvaders_Paint(object sender, PaintEventArgs e)
        {
            // Caso _gameOver seja verdadeiro, escrever FIM DO JOGO com letras grandes amarelas
            // no meio da tela. Em seguida, escrever "Pressione S para iniciar um novo jogo ou
            // Q para sair" no canto inferior direito.
            _game.Draw(_g, _animationCell);
        }

        private void FormInvaders_OnGameOver(object sender, EventArgs e)
        {
            // Adicionar um tratador de evento no objeto Game chamado GameOver
            // que pare o timer do jogo (mas não a animação), atribua true para
            // _gameOver e chame o método Refresh() do formulário.
        }
    }
}
