using System;
using System.Collections.Generic;
using System.Drawing; // Acesso à classe Rectangle
using System.Windows.Forms;

namespace TheMission
{
    public class Game
    {
        /// <summary>
        /// O formulário interage com Player apenas através dos métodos em Game.
        /// </summary>
        private readonly Player _player;

        /// <summary>
        /// Nível atual.
        /// </summary>
        public int Level { get; private set; }
        /// <summary>
        /// Limites e dimensões da masmorra.
        /// </summary>
        public Rectangle Boundaries { get; }
        /// <summary>
        /// Lista de inimigos do nível atual.
        /// </summary>
        public List<Enemy> Enemies { get; set; }
        /// <summary>
        /// Arma disponível no nível atual.
        /// </summary>
        public Weapon WeaponInRoom { get; set; }

        /// <summary>
        /// Localização atual do jogador.
        /// </summary>
        public Point PlayerLocation => _player.Location;
        /// <summary>
        /// Pontos de vida do jogador.
        /// </summary>
        public int PlayerHitPoints => _player.HitPoints;
        /// <summary>
        /// Lista de armas e itens do jogador.
        /// </summary>
        public List<string> PlayerWeapons => _player.Weapons;

        /// <summary>
        /// Game começa criando uma caixa que envolve a masmorra e cria um novo objeto Player nela.
        /// </summary>
        /// <param name="boundaries">Limites da masmorra</param>
        public Game(Rectangle boundaries)
        {
            Boundaries = boundaries;
            _player = new Player(this, new Point(Boundaries.Left + 10, Boundaries.Top + 70), Boundaries);
        }

        /// <summary>
        /// Obtém uma localização aleatória válida na masmorra.
        /// </summary>
        /// <param name="random">Variável tipo aleatório.</param>
        /// <returns></returns>
        private Point GetRandomLocation(Random random)
        {
            // Útil para o método NewLevel(), usado para determinar onde colocar 
            // os inimigos e as armas.

            return new Point(Boundaries.Left +
                (random.Next((Boundaries.Right / 10) - (Boundaries.Left / 10)) * 10),
                Boundaries.Top +
                (random.Next((Boundaries.Bottom / 10) - (Boundaries.Top / 10)) * 10));
        }

        /// <summary>
        /// Move o jogador na direção informada e move cada inimiog em uma direção aleatória.
        /// </summary>
        /// <param name="direction">Direção do movimento.</param>
        /// <param name="random">Variável tipo aleatório.</param>
        public void Move(Direction direction, Random random)
        {
            _player.Move(direction);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        /// <summary>
        /// Prepara uma arma para uso.
        /// </summary>
        /// <param name="weaponName">Nome da arma.</param>
        public void Equip(string weaponName)
        {
            _player.Equip(weaponName);
        }

        /// <summary>
        /// Verifica se o jogador possui uma determinada arma.
        /// </summary>
        /// <param name="weaponName">Nome da arma.</param>
        /// <returns></returns>
        public bool CheckPlayerInventory(string weaponName)
        {
            return _player.Weapons.Contains(weaponName);
        }

        /// <summary>
        /// Ataca o jogador, causando uma quantidade aleatória de dano até um certo limite.
        /// </summary>
        /// <param name="maxDamage">Valor máximo.</param>
        /// <param name="random">Variável tipo aleatória.</param>
        public void HitPlayer(int maxDamage, Random random)
        {
            _player.Hit(maxDamage, random);
        }

        /// <summary>
        /// Semelhante a Move(). O jogador ataca e todos os inimigos têm sua vez de jogar.
        /// </summary>
        /// <param name="direction">Direção do ataque.</param>
        /// <param name="random">Variável tipo aleatória.</param>
        public void Attack(Direction direction, Random random)
        {
            _player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        /// <summary>
        /// Sobe de nível.
        /// </summary>
        /// <param name="random">Variável do tipo aleatória.</param>
        public void NewLevel(Random random)
        {
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
                    Enemies = new List<Enemy>
                    {
                        new Bat(this, GetRandomLocation(random), Boundaries)
                    };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies = new List<Enemy>
                    {
                        new Ghost(this, GetRandomLocation(random), Boundaries)
                    };
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>
                    {
                        new Ghoul(this, GetRandomLocation(random), Boundaries)
                    };
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies = new List<Enemy>
                    {
                        new Bat(this, GetRandomLocation(random), Boundaries),
                        new Ghost(this, GetRandomLocation(random), Boundaries)
                    };
                    WeaponInRoom = !_player.Weapons.Contains("Arco") ?
                        new Bow(this, GetRandomLocation(random)) :
                        (Weapon)new BluePotion(this, GetRandomLocation(random));

                    break;
                case 5:
                    Enemies = new List<Enemy>
                    {
                        new Bat(this, GetRandomLocation(random), Boundaries),
                        new Ghoul(this, GetRandomLocation(random), Boundaries)
                    };
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies = new List<Enemy>
                    {
                        new Ghost(this, GetRandomLocation(random), Boundaries),
                        new Ghoul(this, GetRandomLocation(random), Boundaries)
                    };
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies = new List<Enemy>
                    {
                        new Bat(this, GetRandomLocation(random), Boundaries),
                        new Ghost(this, GetRandomLocation(random), Boundaries),
                        new Ghoul(this, GetRandomLocation(random), Boundaries)
                    };
                    WeaponInRoom = !_player.Weapons.Contains("Bastão") ?
                        new Mace(this, GetRandomLocation(random)) :
                        (Weapon)new RedPotion(this, GetRandomLocation(random));
                    break;
                case 8:
                    MessageBox.Show("Você concluiu o jogo!", "Vitória",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                    break;
            }
        }
    }
}