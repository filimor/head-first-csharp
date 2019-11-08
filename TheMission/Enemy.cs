using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMission
{
    public abstract class Enemy : Mover
    {
        // Enemies não tem um método Attack() porque seu ataque
        // foi incluído em Move().

        public int HitPoints { get; set; }

        public void Hit(int maxDamage, Random random)
        {

        }

        public override Point Move(Random random)
        {
            
        }
    }
}
