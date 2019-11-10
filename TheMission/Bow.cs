using System;
using System.Drawing;

namespace TheMission
{
    public class Bow : Weapon
    {
        public override string Name => "Arco";

        public Bow(Game game, Point location) : base(game, location)
        {
        }

        public override void Attack(Direction direction, Random random)
        {
            // O arco possui um ângulo muito restrito de ataque, mas tem um
            // alcance bem grande - o raio de ataque é 30, mas ele só causa
            // 1 ponto de dano. Ao contrário da espada, que ataca em três
            // direções (porque o jogador a movimenta num grande arco),
            // quando o jogador usa o arco em uma direção, ele apenas atira
            // nessa única direção.
        }
    }
}