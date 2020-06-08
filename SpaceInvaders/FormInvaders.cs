using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Random _random = new Random();

        public FormInvaders()
        {
            InitializeComponent();
            _game = new Game(DisplayRectangle, _random);
            _game.GameOver += FormInvaders_OnGameOver;
        }

        /// <summary>
        /// Mantem a animação, fazendo as estrelas piscarem e as imagens dos invasores mudarem de quadro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrAnimator_Tick(object sender, EventArgs e)
        {
            switch (_counter)
            {
                case 0:
                    _animationCell = 0;
                    _counter++;
                    break;

                case 1:
                    _animationCell = 1;
                    _counter++;
                    break;

                case 2:
                    _animationCell = 2;
                    _counter++;
                    break;

                case 3:
                    _animationCell = 3;
                    _counter++;
                    break;

                case 4:
                    _animationCell = 2;
                    _counter++;
                    break;

                case 5:
                    _animationCell = 1;
                    _counter = 0;
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
            if (_keysPressed.Count >= 1)
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
            if (e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }
            if (_gameOver && e.KeyCode == Keys.S)
            {
                // Aqui vai o código para reiniciar o jogo e resetar os timers.
                _game = new Game(DisplayRectangle, _random);
                _keysPressed.Clear();
                tmrGame.Start();
                return;
            }
            if (e.KeyCode == Keys.Space)
            {
                _game.FireShot();
            }
            if (_keysPressed.Contains(e.KeyCode))
            {
                _keysPressed.Remove(e.KeyCode);
            }
            _keysPressed.Add(e.KeyCode);
            // Removendo a tecla a adicionando-a novamente, fazemos com que ela seja a última (mais
            // atual) contida na lista.
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
            _g = e.Graphics;
            _game.Draw(_g, _animationCell, _gameOver);
        }

        private void FormInvaders_OnGameOver(object sender, EventArgs e)
        {
            // Adicionar um tratador de evento no objeto Game chamado GameOver que pare o timer do
            // jogo (mas não a animação), atribua true para _gameOver e chame o método Refresh() do formulário.
            tmrGame.Stop();
            _gameOver = true;
            Refresh();
        }
    }
}