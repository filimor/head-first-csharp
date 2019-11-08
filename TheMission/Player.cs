using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMission
{
    public class Player : Mover
    {
        public List<Weapon> Weapons { get; set; }
        public int HitPoints { get; set; }

        public void Attack(Direction direction, Random random)
        {

        }

        public void Hit(int maxDamage, Random random)
        {

        }

        public void Equip(string weaponName)
        {

        }

        public override Point Move(Direction direction)
        {
            
        }
    }
}
