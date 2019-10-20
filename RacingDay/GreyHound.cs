using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingDay
{
    public class GreyHound
    {
        public int StartingPosition { get; set; }
        public int RacetrackLenght { get; set; }
        public PictureBox MyPictureBox { get; set; }
        public int Location { get; set; }
        public Random MyRandom { get; set; } = new Random();

        public GreyHound(int startingPosition, int racetrackLenght, PictureBox myPictureBox)
        {
            StartingPosition = startingPosition;
            RacetrackLenght = racetrackLenght;
            MyPictureBox = myPictureBox;
        }

        public bool Run()
        {
            // Mova-se para frente 1, 2, 3 ou 4 espaços aleatoriamente
            // Atualize a posição da minha caixa de imagem no formulário
            // Retorne True se eu ganhei a corrida

            // Exemplo:
            // Point p = MyPictureBox.Location;
            // p.X += distance;
            // MyPictureBox.Location = p;          

        }

        public void TakeStartingPosition()
        {
            // Volte minha posição para a linha de partida
        }
    }
}
