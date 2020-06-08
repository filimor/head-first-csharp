using System;
using System.Drawing;

namespace TheMission
{
    public class Sword : Weapon
    {
        public override string Name => "Espada";

        public Sword(Game game, Point location) : base(game, location)
        {
        }

        public override void Attack(Direction direction, Random random)
        {
            // O objeto Game passará a direção na qual o ataque deve ser feito. A espada é a
            // primeira arma que o jogador pega. Ela tem um grande ângulo de ataque: primeiro
            // atingirá um inimigo que está na direção do ataque - se não existir nenhum inimigo lá,
            // ela continua o ataque no sentido horário da direção original e atinge qualquer
            // inimigo ali, e se ainda não acertar, continua no sentido anti-
            // -horário da direção original do ataque. Ela tem um raio de 10 e causa 3 pontos de dano.

            // Pense cuidadosamente sobre isso... o que é a direita da esquerda? O que é a esquerda
            // da direção para cima?

            switch (direction)
            {
                case Direction.Up:
                    if (DamageEnemy(Direction.Up, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Left, 10, 3, random))
                    {
                        return;
                    }
                    DamageEnemy(Direction.Right, 10, 3, random);
                    break;

                case Direction.Down:
                    if (DamageEnemy(Direction.Down, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Right, 10, 3, random))
                    {
                        return;
                    }
                    DamageEnemy(Direction.Left, 10, 3, random);
                    break;

                case Direction.Right:
                    if (DamageEnemy(Direction.Right, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Up, 10, 3, random))
                    {
                        return;
                    }
                    DamageEnemy(Direction.Down, 10, 3, random);
                    break;

                case Direction.Left:
                    if (DamageEnemy(Direction.Left, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Down, 10, 3, random))
                    {
                        return;
                    }
                    DamageEnemy(Direction.Up, 10, 3, random);
                    break;
            }
        }
    }
}