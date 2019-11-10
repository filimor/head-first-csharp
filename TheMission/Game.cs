using System;
using System.Collections.Generic;
using System.Drawing; // Acesso à classe Rectangle

namespace TheMission
{
    public class Game
    {
        private readonly Player _player; // O formulário interage com Player apenas através dos métodos em Game.

        public int Level { get; private set; }
        public Rectangle Boundaries { get; } // Rectangle possui os campos Top, Bottom, Left e Right.
        public List<Enemy> Enemies { get; set; } // Públicas desde que as classes estejam bem encapsuladas.
        public Weapon WeaponInRoom { get; set; } // Públicas desde que as classes estejam bem encapsuladas.

        public Point PlayerLocation => _player.Location;
        public int PlayerHitPoints => _player.HitPoints;
        public List<string> PlayerWeapons => _player.Weapons;

        public Game(Rectangle boundaries)
        {
            // Game começa criando uma caixa que envolve a masmorra e cria um novo objeto Player nela.

            Boundaries = boundaries;
            _player = new Player(this, new Point(Boundaries.Left + 10, Boundaries.Top + 70), Boundaries);
        }

        private Point GetRandomLocation(Random random)
        {
            // Útil para o método NewLevel(), usado para determinar onde colocar
            // os inimigos e as armas.

            return new Point(Boundaries.Left +
                (random.Next((Boundaries.Right / 10) - (Boundaries.Left / 10)) * 10),
                Boundaries.Top +
                (random.Next((Boundaries.Bottom / 10) - (Boundaries.Top / 10)) * 10));
        }

        public void Move(Direction direction, Random random)
        {
            // O movimento é simples: mova o jogador na direção queo formulário informa e
            // mova cada inimigo em uma direção aleatória.

            _player.Move(direction);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        public void Equip(string weaponName)
        {
            _player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return _player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            _player.Hit(maxDamage, random);
        }

        public void Attack(Direction direction, Random random)
        {
            // Attack() é quase igual a Move(). O jogador ataca e todos os
            // inimigos têm sua vez de jogar.

            _player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        public void NewLevel(Random random)
        {
            // Adicionar comandos case para outros níveis.
            // Se o jogador já possui a poção de uma cor, o jogo não deve
            // adicioná-la ao nível.

            // Nível 2 -- Fantasma -- Poção azul
            // Nível 3 -- Zumbi -- Arco
            // Nível 4 -- Morcego, Fantasma -- Arco / Poção azul
            // Nível 5 -- Morcego, Zumbi -- Poção vermelha
            // Nível 6 -- Fantasma, Zumbi -- Bastão
            // Nível 7 -- Morcego, Fantasma, Zumbi -- Bastão / Poção vermelha
            // Nível 8 N/A -- Termine o jogo com Application.Exit();

            Level++;
            switch (Level)
            {
                case 1:
                    Enemies = new List<Enemy> { new Bat(this, GetRandomLocation(random), Boundaries) };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
            }
        }
    }
}