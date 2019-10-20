using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingDay
{
    public partial class FormRacingDay : Form
    {

        Guy[] guys = new Guy[3];
        GreyHound[] greyHounds = new GreyHound[4];

        public FormRacingDay()
        {
            InitializeComponent();

            guys[0] = new Guy("João", 50, rdoJoao, lblJoao);
            guys[1] = new Guy("Beto", 75, rdoBeto, lblBeto);
            guys[2] = new Guy("Alfredo", 45, rdoAlfredo, lblAlfredo);

            int startPos = picRaceTrack.Left + 12;

            greyHounds[0] = new GreyHound(startPos, picRaceTrack.Width, picDog1);
            greyHounds[1] = new GreyHound(startPos, picRaceTrack.Width, picDog2);
            greyHounds[2] = new GreyHound(startPos, picRaceTrack.Width, picDog3);
            greyHounds[3] = new GreyHound(startPos, picRaceTrack.Width, picDog4);

        }
    }
}
