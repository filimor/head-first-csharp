using System;
using System.Collections.Generic;
using System.Drawing;

namespace TheMission
{
    public class Player : Mover
    {
        // Todas as propriedades de Player estão ocultas para acesso direto.

        private Weapon _eqquipedWeapon;

        public int HitPoints { get; set; }
        public List<Weapon> Inventory { get; set; } = new List<Weapon>();

        public List<string> Weapons
        {
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
                if (weapon.Name == weaponName)
                {
                    _eqquipedWeapon = weapon;
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            // O método é chamado quando um dos botões de ataque do formulário é clicado.
            // Todas armas têm um método Attack(). Esse método verifica qual arma está
            // preparada e chama o Attack() da arma. Se a arma for uma poção, Attack()
            // remove-a do inventário após o jogador bebê-la.
            // Potions implementará uma interface IPotion, então pode-se usar a palavra
            // is para ver se Weapon é uma implementação de IPotion.
        }

        public override Point Move(Direction direction)
        {
            // Game chama o método Move() de Player quando um dos botões de
            // movimento do formulário é clicado.

            location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                // Veja se tem uma arma por perto, se for possivel, pegue-a.
                // Se a arma for a única do jogador, prepare-a imediatamente.
                // Weapon e o formulário serão responsáveis por deixar a PictureBox
                // da arma invisível quando o jogador pegar, e não Player.
                // Quando o jogador pega uma arma, ela precisa desaparecer da
                // masmorra e aparecer no inventário.
            }
        }
    }
}