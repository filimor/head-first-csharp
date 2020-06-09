using System;
using System.Collections.Generic;
using System.Drawing;

namespace TheMission
{
    /// <summary>
    /// Todas as propriedades de Player estão ocultas para acesso direto.
    /// </summary>
    public class Player : Mover
    {
        private Weapon _eqquipedWeapon;
        private const int WEAPONCATCHRADIUS = 10;
        private Rectangle _boundaries;

        public int HitPoints { get; set; } = 10;
        new public Point Location { get; private set; }
        public List<Weapon> Inventory { get; } = new List<Weapon>();

        /// <summary>
        /// O jogador pode guardar muitas armas no inventário, mas só pode usar uma de cada vez.
        /// </summary>
        public List<string> Weapons
        {
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
            // HitPoints = 10;
            _boundaries = boundaries;
        }

        /// <summary>
        /// Quando um inimigo ataca o jogador, ele causa uma quantidade de dano aleatória.
        /// </summary>
        /// <param name="health">Pontos de vida do jogador</param>
        /// <param name="random">Variável do tipo aleatória.</param>
        public void Hit(int health, Random random)
        {
            HitPoints -= random.Next(1, health);
        }

        /// <summary>
        /// Quando o jogador usa uma poção, ele recebe uma quantidade de pontos de vida aleatória.
        /// </summary>
        /// <param name="health">Pontos de vida do jogador.</param>
        /// <param name="random">Variável do tipo aleatória.</param>
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        /// <summary>
        /// Diz ao jogador para usar uma de suas armas.
        /// </summary>
        /// <param name="weaponName">Nome da arma.</param>
        public void Equip(string weaponName)
        {
            // O objeto Game chama esse método quando um dos ícones no inventário é clicado. Um
            // objeto Player só pode ter um objeto Weapon em uso por vez.

            foreach (Weapon weapon in Inventory)
            {
                if (weapon.Name == weaponName)
                {
                    _eqquipedWeapon = weapon;
                }
            }
        }

        /// <summary>
        /// Chama o Attack() da arma que está preparada. Se for uma poção, emove-a do inventário.
        /// </summary>
        /// <param name="direction">Direção do ataque.</param>
        /// <param name="random">Variável tipo aleatória.</param>
        public void Attack(Direction direction, Random random)
        {
            // O método é chamado quando um dos botões de ataque do formulário é clicado.

            if (_eqquipedWeapon != null)
            {
                _eqquipedWeapon.Attack(direction, random);
                if (_eqquipedWeapon is IPotion)
                {
                    Inventory.Remove(_eqquipedWeapon);
                }
            }
        }

        /// <summary>
        /// Move o jogador na direção especificada.
        /// </summary>
        /// <param name="direction">Direção do movimento.</param>
        public void Move(Direction direction)
        {
            // Game chama o método Move() de Player quando um dos botões de movimento do formulário
            // é clicado.

            Weapon weaponInRoom = _game.WeaponInRoom;
            Location = Move(direction, _boundaries);
            if (!weaponInRoom.PickedUp)
            {
                // Veja se tem uma arma por perto, se for possivel, pegue-a. Se a arma for a única
                // do jogador, prepare-a imediatamente. Weapon e o formulário serão responsáveis por
                // deixar a PictureBox da arma invisível quando o jogador pegar, e não Player.
                // Quando o jogador pega uma arma, ela precisa desaparecer da masmorra e aparecer no inventário.

                if (Nearby(weaponInRoom.Location, WEAPONCATCHRADIUS))
                {
                    int totalWeapons = 0;
                    Inventory.Add(weaponInRoom);
                    foreach (Weapon weapon in Inventory)
                    {
                        if (!(weapon is IPotion))
                        {
                            totalWeapons++;
                        }
                        if (totalWeapons == 1)
                        {
                            Equip(weapon.Name);
                        }
                    }
                    weaponInRoom.PickupWeapon();
                }
            }
        }
    }
}