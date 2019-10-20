using System;
using System.Drawing;
using System.Windows.Forms;

namespace RacingDay
{
    public class GreyHound
    {
        public int StartingPosition { get; }
        public int RacetrackLenght { get; }
        public PictureBox MyPictureBox { get; }
        public int Location { get; private set; }
        public Random MyRandom { get; } = new Random();

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

            int distance = MyRandom.Next(1, 5);
            Point p = MyPictureBox.Location;
            Location = p.X += distance;
            MyPictureBox.Location = p;

            return Location >= RacetrackLenght - MyPictureBox.Width;
        }

        public void TakeStartingPosition()
        {
            // Volte minha posição para a linha de partida

            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}