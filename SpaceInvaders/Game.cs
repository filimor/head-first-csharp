using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SpaceInvaders
{
    public class Game
    {
        private int _score;
        private int _livesLeft = 2;
        private int _wave;

        /// <summary>
        /// Usado para deixar os invasores mais lentos no começo do jogo.
        /// A primeira horda pula 6 quadros antes de se mover, a próxima
        /// 5 e assim por diante.
        /// </summary>
        private int _framesSkipped = 6;

        private Rectangle _boundaries;
        private Random _random;
        private Direction _invaderDirection;
        private List<Invader> _invaders;
        private PlayerShip _playerShip;
        private List<Shot> _playerShots;
        private List<Shot> _invaderShots;
        private Stars _stars;

        /// <summary>
        /// O objeto Game dispara o evento GameOver quando o jogador morre.
        /// </summary>
        public event EventHandler GameOver;

        public Game(Rectangle boundaries, Random random)
        {
            // O objeto Game precisa criar todos os demais objetos: os Invader, o PlayerShip,
            // as listas de tiros e o objeto Stars. O formulário passa um objeto Random
            // inicializado e sua própria estrutura DisplayRectangle para que game possa
            // determinar os limites do campo de batalha, o que será usado para determinar se
            // os tiros saíram da tela e se os invasores atingiram oas bordas.

            _boundaries = boundaries;
            _random = random;
            _invaders = new List<Invader>();
            _playerShip = new PlayerShip();
            _playerShots = new List<Shot>();
            _invaderShots = new List<Shot>();
            _stars = new Stars(_boundaries, _random);
            NextWave();
        }

        /// <summary>
        /// Desenha o jogo num objeto Graphics.
        /// </summary>
        /// <param name="g">Objeto Graphics</param>
        /// <param name="animationCell">Número de 0 a 3 com a célula de animação.</param>
        public void Draw(Graphics g, int animationCell, bool gameOver)
        {
            // Primeiro, ele deve desenhar um retângulo preto que preencha todo o formulário
            // (usando o retângulo de exibição em _boundaries, recebido do formulário). Então
            // o método deve desenhar as estrelas, os invasores, a nave do jogo e depois os
            // tiros. Finalmente, ele deve desenhar a pontuação no canto superior esquerdo,
            // as naves do jogador no superior direito e um grande "FIM DE JOGO" em letras
            // amarelas se gameOver for true.

            g.FillRectangle(Brushes.Black, _boundaries);

            _stars.Draw(g);
            foreach (Invader invader in _invaders)
            {
                invader.Draw(g, animationCell);
            }
            _playerShip.Draw(g);
            foreach (Shot shot in _playerShots)
            {
                shot.Draw(g);
            }
            foreach (Shot shot in _invaderShots)
            {
                shot.Draw(g);
            }

            using (var arial12 = new Font("Arial", 12))
            {
                g.DrawString(_score.ToString(), arial12, Brushes.White, 10, 10);
                g.DrawString(_livesLeft.ToString(), arial12, Brushes.White, _boundaries.Width - 30, 10);
            }

            if (gameOver)
            {
                using (var arial24 = new Font("Arial", 24))
                using (var arial12 = new Font("Arial", 12))
                {
                    g.DrawString("FIM DE JOGO", arial24, Brushes.Yellow, (_boundaries.Width / 2) - 100, (_boundaries.Height / 2) - 10);
                    g.DrawString("Pressione S para iniciar um novo jogo ou Q para sair...", arial12, Brushes.White,
                        _boundaries.Width - 400, _boundaries.Height - 30);
                }
            }
        }

        /// <summary>
        /// Faz as estrelas piscarem.
        /// </summary>
        public void Twinkle()
        {
            _stars.Twinkle(_random);
        }

        /// <summary>
        /// Movimenta o jogador.
        /// </summary>
        /// <param name="direction">Direção do movimento.</param>
        public void MovePlayer(Direction direction)
        {
            if (_playerShip.Alive)
            {
                _playerShip.Move(direction);
            }
        }

        /// <summary>
        /// Faz com que o jogador dispare um tiro nos invasores.
        /// </summary>
        public void FireShot()
        {
            // Verifica se existem menos de dois tiros do jogador na tela. Se for o caso,
            // ele deve adicionar um novo tiro na lista _playerShots na posição correta.
            if (_playerShots.Count < 2)
            {
                _playerShots.Add(new Shot(new Point(_playerShip.Location.X, _playerShip.Location.Y - 10), Direction.Up, _boundaries));
            }
        }

        /// <summary>
        /// Acionado toda vez que avançar um quadro.
        /// </summary>
        public void Go()
        {
            // 1. Verificar se o jogador morreu.
            // Mostrar uma pequena animação da nave implodindo, usando DrawImage()
            // parar fazer ela encolher até desaparecer. A animação deve ser feita
            // pela classe PlayerShip.

            // O formulário deverá parar o timer de animação com seu método Stop().
            // Nessas condições, o método Go() não fará mais nada até que o jogador
            // esteja vivo de novo, ele deve apenas retornar.
            if (!_playerShip.Alive)
            {
                return;
            }

            // 2. Movimentar cada um dos tiros.
            // Os disparos dos invasores movem-se para baixo e os do jogador para cima.
            // Qualquer tiro que se mover para fora da tela deve ser removido da lista.

            // O jogo precisa iterar pelos dois objetos List<Shot> chamando o método Move()
            // de cada tiro encontrado. Se algum desses métodos retornar false, ou seja,
            // esse tiro saiu da tela - então ele deve ser apagado da lista.

            for (int i = 0; i < _playerShots.Count; i++)
            {
                if (!_playerShots[i].Move(Direction.Up))
                {
                    _playerShots.Remove(_playerShots[i]);
                }
            }
            for (int j = 0; j < _invaderShots.Count; j++)
            {
                if (!_invaderShots[j].Move(Direction.Down))
                {
                    _invaderShots.Remove(_invaderShots[j]);
                }
            }

            // 3. Movimentar cada um dos invasores.
            // Chamar o método Move() de cada um dos invasores e dizer-lhes para que lado ir.
            // Manter o registro das posições para o caso de precisar movimentá-los para
            // baixou um mudar de direção.
            // Depois, verifica se é hora dos invasores atirarem e, se foro caso, adiciona
            // um novo obeto Shot na lista.

            // O jogo avança cada invasor e permite que eles disparem.

            MoveInvaders();
            ReturnFire();

            // 4. Checar colisões.
            // Finalmente, checa para ver se colisões ocorreram. Primeiro se algum tiro
            // passou por cima de algum invasor (e nesse caso ambos são removidos de suas
            // listas) e se o jogador foi atingido. Usar o método Contains() da propriedade
            // Area e determinar se a área da nave se sobrepõe à de um tiro.

            CheckForInvaderCollisions();
            CheckForPlayerCollisions();
        }

        /// <summary>
        /// Cria uma nova horda de invasores.
        /// </summary>
        private void NextWave()
        {
            // Ele deve adicionar uma nova lista de objetos Invader no campo de batalha,
            // colocando 30 invasores em suas posições iniciais em seis colunas, aumentar
            // o campo wave em 1 e configurar o campo invaderDirection para que os invasores
            // comecem a se movimentar inicialmente para o lado direito da tela. Ele também
            // deve mudar o campo framesSkipped.

            for (int i = 1; i < 6; i++)
            {
                _invaders.Add(new Invader(Invader.Type.Satellite, new Point(_boundaries.X + (40 * i) + 20, _boundaries.Y + 20), 50));
            }
            for (int i = 1; i < 6; i++)
            {
                _invaders.Add(new Invader(Invader.Type.Bug, new Point(_boundaries.X + (40 * i) + 20, _boundaries.Y + 40), 60));
            }
            for (int i = 1; i < 6; i++)
            {
                _invaders.Add(new Invader(Invader.Type.Saucer, new Point(_boundaries.X + (40 * i) + 20, _boundaries.Y + 100), 30));
            }
            for (int i = 1; i < 6; i++)
            {
                _invaders.Add(new Invader(Invader.Type.Spaceship, new Point(_boundaries.X + (40 * i) + 20, _boundaries.Y + 140), 20));
            }
            for (int i = 1; i < 6; i++)
            {
                _invaders.Add(new Invader(Invader.Type.Star, new Point(_boundaries.X + (40 * i) + 20, _boundaries.Y + 180), 10));
            }

            _wave++;
            _invaderDirection = Direction.Right;
            _framesSkipped = 7 - _wave;
        }

        /// <summary>
        /// Move todos os invasores.
        /// </summary>
        private void MoveInvaders()
        {
            // Os invasores precisam mudar de direção se qualquer um deles estiver dentro
            // de uma área de 100 pixels da borda do campo de batalha. Quando isso acontece,
            // eles precisam descer e mudar de direção.
            // A primeira coisa a fazer é verificar e atualizar o campo privado frameSkipped
            // e retornar se o quadro em que estivermos tiver de ser pulado (dependendo do
            // número da horda). Então ele deve checar para qual direção os invasores estão
            // se movendo e usar LINQ para procuar na lista InvaderCollection por qualquer
            // invasor a menos de 100 pixels do limite. Se algum for encontrado, eles devem
            // ser informados para marchar para baixo e invaderDirection deve ser alterado.
            // Se nenhum for encontrado, eles devem marchar na mesma direção.

            _framesSkipped--;
            if (_framesSkipped < 0)
            {
                _framesSkipped = 7 - _wave;
            }
            else if (_framesSkipped != 0)
            {
                return;
            }

            switch (_invaderDirection)
            {
                case Direction.Right:
                    IEnumerable<Invader> invadersToRight =
                        from invader in _invaders
                        where invader.Location.X >= _boundaries.Width - 100
                        select invader;
                    if (invadersToRight.Any())
                    {
                        foreach (Invader invader in _invaders)
                        {
                            invader.Move(Direction.Down);
                        }
                        _invaderDirection = Direction.Left;
                    }
                    else
                    {
                        foreach (Invader invader in _invaders)
                        {
                            invader.Move(Direction.Right);
                        }
                    }
                    break;

                case Direction.Left:
                    IEnumerable<Invader> invadersToLeft =
                        from invader in _invaders
                        where invader.Location.X <= _boundaries.X + 100
                        select invader;
                    if (invadersToLeft.Any())
                    {
                        foreach (Invader invader in _invaders)
                        {
                            invader.Move(Direction.Down);
                        }
                        _invaderDirection = Direction.Right;
                    }
                    else
                    {
                        foreach (Invader invader in _invaders)
                        {
                            invader.Move(Direction.Left);
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Permite aos invasores dispararem.
        /// </summary>
        private void ReturnFire()
        {
            // Primeiro ele deve retornar se a lista de tiros dos invasores já possuir
            // wave + 1 tiro. Ele também deve retornar se Random.Next(10) < 10 - wave
            // (para que os invasores não disparem o tempo todo).
            // Se os testes falharem, ele pode usar LINQ para agrupar os invasores por suas
            // Location.X e ordenar usando descending. Uma vez que se tenham os grupos,
            // pode-se escolher um deles ao acaso e usar seu método First() para achar o
            // invasor mais abaixo da coluna. Então você pode adicionar um disparo na lista
            // de tiros dos invasores exatamente abaixo do meio desse invasor (usar a Area
            // dos invasores para determinar a posição do tiro).

            if (_invaderShots.Count >= _wave + 1 || _random.Next(10) < 10 - _wave)
            {
                return;
            }

            IOrderedEnumerable<IGrouping<int, Invader>> invadersQuery =
                from invader in _invaders
                group invader by invader.Location.X into invaderGroup
                orderby invaderGroup.Key descending
                select invaderGroup;
            IGrouping<int, Invader> selectedGroup = invadersQuery.ElementAt(_random.Next(1, invadersQuery.Count()));
            Invader selectedInvader = selectedGroup.First();
            _invaderShots.Add(new Shot(new Point(selectedInvader.Area.X + 3, selectedInvader.Area.Y + 5), Direction.Down, _boundaries));
        }

        // Existem três tipos de colisão para verificar e o método Contains() da struct
        // Rectangle será muito útil - passe a ele qualquer Point e ele retornará true
        // se o ponto estiver dentro do retângulo.

        /// <summary>
        /// Verifica se algum dos invasores foi atingido.
        /// </summary>
        private void CheckForInvaderCollisions()
        {
            // Use LINQ para achar qualquer invasor morto iterando pelos tiros da lista
            // de disparos do jogador e selecione qualquer invasor cuja Area contiver
            // a posição do tiro. Remova o invasor e o tiro.
            // Adicione uma consulta para determinar se qualquer invasor atingiu a parte
            // inferior da tela - se for o caso, encerre o jogo.

            IEnumerable<Shot> shotsQuery =
                from shot in _playerShots
                select shot;

            IEnumerable<Invader> invadersQuery =
                from invader in _invaders
                select invader;

            foreach (Invader invader in invadersQuery)
            {
                foreach (Shot shot in shotsQuery)
                {
                    if (invader.Area.Contains(shot.Location))
                    {
                        _playerShots.Remove(shot);
                        _invaders.Remove(invader);
                    }
                }
                if (invader.Location.Y >= _boundaries.Height - invader.Area.Height)
                {
                    GameOver(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Verifica se o jogador foi atingido.
        /// </summary>
        private void CheckForPlayerCollisions()
        {
            // Você não vai precisar de LINQ para procurar por tiros colididos com o jogador,
            // apenas um laço e a propriedade Area dele (lembre-se, você não pode modificar
            // uma coleção dentro de um laço foreach. Se tentar, vai conseguir uma
            // InvalidOperationException dizendo que a coleção foi modificada).

            // Em seguida, deverá checar se algum dos tiros invasores colidiu
            // com a nave do jogador. Nesse caso, ele mata-o atribuindo false à sua
            // propriedade Alive. Se o jogador não tiver mais vidas, Game deverá levantar
            // o evento GameOver para informar o formulário que o jogo acabou. O tratador
            // de evento GameOver do formulário interrompe o timer do jogo, então Go() não
            // será mais chamada.

            for (int i = 0; i < _invaderShots.Count; i++)
            {
                if (_playerShip.Area.Contains(_invaderShots[i].Location))
                {
                    _invaderShots.Remove(_invaderShots[i]);
                    _playerShip.Alive = false;
                    if (_livesLeft == 0)
                    {
                        GameOver(this, EventArgs.Empty);
                    }
                }
            }
        }
    }
}