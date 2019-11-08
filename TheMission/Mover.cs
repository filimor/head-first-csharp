using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMission
{
    public abstract class Mover
    {
        public Point Location;

        public bool Nearby(Point locationToCheck, int distance)
        {
            // Pega um ponto e calcula se ele está a uma certa distância do objeto.
        }

        public virtual Point Move(Direction direction, Rectangle boundaries)
        {
            // Recebe uma direção, assim como os limites da masmorra, e calcula
            // onde seria o ponto final desse movimento.
        }

    }
}
