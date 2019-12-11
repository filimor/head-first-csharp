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
        public int Live { get; set; }
        public int Horde { get; set; }
        public List<Invader> Invaders { get; set; }
        public PlayerShip PlayerShip { get; set; }
        public List<Shot> PlayerShots { get; set; }
        public List<Shot> InvaderShots { get; set; }
        public Stars Stars { get; set; }
        public bool Alive { get; set; }

        public Game(Rectangle boundaries)
        {

        }

        public void Draw(Graphics g, int animationCell)
        {
            Stars.Draw(g);
            foreach(Invader invader in Invaders)
            {
                invader.Draw(g, animationCell);
            }
            PlayerShip.Draw(g);
            foreach(Shot shot in PlayerShots)
            {
                shot.Draw(g);
            }
            foreach(Shot shot in InvaderShots)
            {
                shot.Draw(g);
            }
        }

        public void Twinkle()
        {
            // Faz as estrelas piscarem.
        }

        /// <summary>
        /// Acionado toda vez que avançar um quadro.
        /// </summary>
        public void Go()
        {
            // 1. Verificar se o jogador morreu.
            if (!Alive)
            {
                // Mostrar uma pequena animação da nave implodindo, usando DrawImage()
                // parar fazer ela encolher até desaparecer. A animação deve ser feita
                // pela classe PlayerShip.
                return;
            }
            // 2. Movimentar cada um dos tiros.
            // Os disparos dos invasores movem-se para baixo e os do jogador para cima.
            // Qualquer tiro que se mover para fora da tela deve ser removido da lista.

            // 3. Movimentar cada um dos invasores.
            // Chamar o método Move() de cada um dos invasores e dizer-lhes para que lado ir.
            // Manter o registro das posições para o caso de precisar movimentá-los para
            // baixou um mudar de direção.
            // Depois, verifica se é hora dos invasores atirarem e, se foro caso, adiciona
            // um novo obeto Shot na lista.

            // 4. Checar colisões.
            // Se o tiro do jogador atingir um invador, Game deverá retirá-lo da lista
            // apropriada. Em seguida, deverá checar se algum dos tiros invasores colidiu
            // com a nave do jogador. Nesse caso, ele mata-o atribuindo false à sua
            // propriedade Alive. Se o jogador não tiver mais vidas, Game deverá levantar
            // o evento GameOver para informar o formulário que o jogo acabou. O tratador
            // de evento GameOver do formulário interrompe o timer do jogo, então Go() não
            // será mais chamada.

        }

        public void FireShot()
        {

        }

        public void MovePlayer(Direction direction)
        {

        }
    }
}
