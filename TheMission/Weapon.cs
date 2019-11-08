using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMission
{
    public abstract class Weapon : Mover
    {
        public bool PickedUp { get; set; }
        public Point Location { get; set; }
    }
}
