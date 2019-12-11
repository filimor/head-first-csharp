using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        private int _framesSkipped;
        private Rectangle _boundaries;
        private Random _random;
        private Direction _invaderDirection;
        private List<Invader> _invaders;
        private PlayerShip _playerShip;
        private List<Shot> _playerShots;
        private List<Shot> _invaderShots;
        private Stars _stars;

        public bool Alive { get; set; }
        /// <summary>
        /// O objeto Game dispara o evento GameOver quando o jogador morre.
        /// </summary>
        public event EventHandler GameOver;

        public Game(Rectangle boundaries)
        {
            // O objeto Game precisa criar todos os demais objetos: os Invader, o PlayerShip,
            // as listas de tiros e o objeto Stars. O formulário passa um objeto Random
            // inicializado e sua própria estrutura DisplayRectangle para que game possa
            // determinar os limites do campo de batalha, o que será usado para determinar se
            // os tiros saíram da tela e se os invasores atingiram oas bordas.

            _boundaries = boundaries;
        }

        /// <summary>
        /// Desenha o jogo num objeto Graphics.
        /// </summary>
        /// <param name="g">Objeto Graphics</param>
        /// <param name="animationCell">Número de 0 a 3 com a célula de animação.</param>
        public void Draw(Graphics g, int animationCell)
        {
            // Primeiro, ele deve desenhar um retângulo preto que preencha todo o formulário
            // (usando o retângulo de exibição em _boundaries, recebido do formulário). Então
            // o método deve desenhar as estrelas, os invasores, a neve do jogo e depois os
            // tiros. Finalmente, ele deve desenhar a pontuação no canto superioresquerdo,
            // as naves do jogador no superior direito e um grande "FIM DE JOGO" em letras
            // amarelas se gameOver for true.

            _stars.Draw(g);
            foreach(Invader invader in _invaders)
            {
                invader.Draw(g, animationCell);
            }
            _playerShip.Draw(g);
            foreach(Shot shot in _playerShots)
            {
                shot.Draw(g);
            }
            foreach(Shot shot in _invaderShots)
            {
                shot.Draw(g);
            }
        }

        /// <summary>
        /// Faz as estrelas piscarem.
        /// </summary>
        public void Twinkle()
        {
            _stars.Twinkle();
        }

        /// <summary>
        /// Movimenta o jogador.
        /// </summary>
        /// <param name="direction">Direção do movimento.</param>
        public void MovePlayer(Direction direction)
        {
            if (Alive)
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
            if (!Alive)
            {
                
                return;
            }
            // 2. Movimentar cada um dos tiros.
            // Os disparos dos invasores movem-se para baixo e os do jogador para cima.
            // Qualquer tiro que se mover para fora da tela deve ser removido da lista.

            // O jogo precisa iterar pelos dois objetos List<Shot> chamando o método Move()
            // de cada tiro encontrado. Se algum desses métodos retornar false, ou seja,
            // esse tiro saiu da tela - então ele deve ser apagado da lista.

            // 3. Movimentar cada um dos invasores.
            // Chamar o método Move() de cada um dos invasores e dizer-lhes para que lado ir.
            // Manter o registro das posições para o caso de precisar movimentá-los para
            // baixou um mudar de direção.
            // Depois, verifica se é hora dos invasores atirarem e, se foro caso, adiciona
            // um novo obeto Shot na lista.

            // O jogo avança cada invasor e permite que eles disparem.

            // 4. Checar colisões.
            // Se o tiro do jogador atingir um invador, Game deverá retirá-lo da lista
            // apropriada. Em seguida, deverá checar se algum dos tiros invasores colidiu
            // com a nave do jogador. Nesse caso, ele mata-o atribuindo false à sua
            // propriedade Alive. Se o jogador não tiver mais vidas, Game deverá levantar
            // o evento GameOver para informar o formulário que o jogo acabou. O tratador
            // de evento GameOver do formulário interrompe o timer do jogo, então Go() não
            // será mais chamada.

            // Finalmente, checa para ver se colisões ocorreram. Primeiro se algum tiro
            // passou por cima de algum invasor (e nesse caso ambos são removidos de suas
            // listas) e se o jogador foi atingido. Usar o método Contains() da propriedade
            // Area e determinar se a área da nave se sobrepõe à de um tiro.
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
            // deve mudaro campo framesSkipped.
        }

        /// <summary>
        /// Verifica se o jogador foi atingido.
        /// </summary>
        private void CheckForPlayerCollisions()
        {

        }

        /// <summary>
        /// Verifica se algum dos invasores foi atingido.
        /// </summary>
        private void CheckForInvaderCollisions()
        {

        }

        /// <summary>
        /// Move todos os invasores.
        /// </summary>
        private void MoveInvaders()
        {

        }

        /// <summary>
        /// Permite aos invasores dispararem.
        /// </summary>
        private void ReturnFire()
        {

        }
    }
}
