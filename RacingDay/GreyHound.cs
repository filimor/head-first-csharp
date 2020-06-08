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
        public Random MyRandom { get; private set; }

        public GreyHound(int startingPosition, int racetrackLenght, PictureBox myPictureBox)
        {
            StartingPosition = startingPosition;
            RacetrackLenght = racetrackLenght;
            MyPictureBox = myPictureBox;
        }

        /// <summary>
        /// Move forward 1, 2, 3 or 4 spaces randomly. Update my picturebox position on the form.
        /// </summary>
        /// <returns>Return true if I won the race.</returns>
        public bool Run()
        {
            MyRandom = new Random();
            int distance = MyRandom.Next(1, 5);
            Point p = MyPictureBox.Location;
            Location = p.X += distance;
            MyPictureBox.Location = p;

            Application.DoEvents();
            System.Threading.Thread.Sleep(15);

            return Location >= RacetrackLenght - MyPictureBox.Width;
        }

        /// <summary>
        /// Take back my position to the starting line.
        /// </summary>
        public void TakeStartingPosition()
        {
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}