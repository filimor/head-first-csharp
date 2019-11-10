using System;
using System.Drawing;

namespace TheMission
{
    public class Mace : Weapon
    {
        public override string Name => "Bastão";

        public Mace(Game game, Point location) : base(game, location)
        {
        }

        public override void Attack(Direction direction, Random random)
        {
            // O bastão é a arma mais poderosa da masmorra. Não importa
            // em qual direção o jogador atacar com ela - já que ela faz
            // um círculo completo, atacará qualquer inimigo num raio de 
            // 20 e causará até 6 pontos de dano.

            // As diferentes armas chamarão DamageEnemy() de muitas formas.
            // O bastão ataca em todas as direções. Assim, se o jogador
            // estiver atacando para a direita, ele chamará DamageEnemy
            // (Direction.Right, 20, 6, random). Se não acertar nenhum
            // inimiog, atacará para a frente. Se não houver nenhum inimigo
            // lá, tentará à esquerda e então para trás - um movimento
            // de círculo completo.

            switch (direction)
            {
                case Direction.Up:
                    if (DamageEnemy(Direction.Up, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Right, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Down, 10, 3, random))
                    {
                        return;
                    }
                    DamageEnemy(Direction.Left, 10, 3, random);
                    break;
                case Direction.Down:
                    if (DamageEnemy(Direction.Down, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Left, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Up, 10, 3, random))
                    {
                        return;
                    }
                    DamageEnemy(Direction.Right, 10, 3, random);
                    break;
                case Direction.Right:
                    if (DamageEnemy(Direction.Right, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Down, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Down, 10, 3, random))
                    {
                        return;
                    }
                    DamageEnemy(Direction.Up, 10, 3, random);
                    break;
                case Direction.Left:
                    if (DamageEnemy(Direction.Left, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Up, 10, 3, random))
                    {
                        return;
                    }
                    if (DamageEnemy(Direction.Right, 10, 3, random))
                    {
                        return;
                    }
                    DamageEnemy(Direction.Down, 10, 3, random);
                    break;

            }
        }
    }
}