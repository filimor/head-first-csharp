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
        // Todas as propriedades de Player estão ocultas para acesso direto.

        private Weapon _eqquipedWeapon; 

        public int HitPoints { get; set; }
        public List<Weapon> Inventory { get; set; } = new List<Weapon>();
        public List<string> Weapons {
            // O jogador pode guardar muitas armas no inventário, mas só pode
            // usar uma de cada vez.

            get
            {
                var names = new List<string>();
                foreach (Weapon weapon in Inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
        }

        public Player(Game game, Point location, Rectangle boundaries) : base(game, location)
        {
            HitPoints = 10;
            // Substituir o construtor por uma atribuição de valor na propriedade?
        }

        //public void Attack(Direction direction, Random random)
        //{

        //}

        public void Hit(int health, Random random)
        {
            // Quando um inimigo ataca o jogador, ele causa uma quantidade
            // de dano aleatória.

            HitPoints -= random.Next(1, health);
        }

        public void IncreaseHealth(int health, Random random)
        {
            // Quando o jogador usa uma poção, ele recebe uma quantidade
            // de pontos de vida aleatória.

            HitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            // Diz ao jogador para usar uma de suas armas. O objeto Game chama
            // esse método quando um dos ícones no inventário é clicado.
            // Um objeto Player só pode ter um objeto Weapon em uso por vez.

            foreach (Weapon weapon in Inventory)
            {
                if(weapon.Name == weaponName)
                {
                    _eqquipedWeapon = weapon;
                }
            }
        }

        public override Point Move(Direction direction)
        {
            
        }
    }
}
