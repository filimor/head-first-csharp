using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Stars
    {
        private struct Star
        {
            public Point Point;
            public Pen Pen;

            public Star(Point point, Pen pen)
            {
                Point = point;
                Pen = pen;
            }
        }

        /// <summary>
        /// Armazena 300 structs Star.
        /// </summary>
        private List<Star> StarsOnScreen { get; set; }

        /// <summary>
        /// Povoa a lista de estrelas.
        /// </summary>
        /// <param name="boundaries">Rectangle com os limites de exibição.</param>
        /// <param name="random">Instância de Random para criá-las em posições aleatórias.</param>
        public Stars(Rectangle boundaries, Random random)
        {

        }

        public void Draw(Graphics g)
        {

        }

        /// <summary>
        /// Remove cinco estrelas em posições aleatórias e adiciona cinco novas.
        /// </summary>
        /// <param name="random">Instância de Random.</param>
        public void Twinkle(Random random)
        {

        }

        /// <summary>
        /// Dá uma cor aleatória às estrelas quando criadas.
        /// </summary>
        /// <returns>Retorna uma das cinco cores possíveis.</returns>
        private Pen RandomPen()
        {
            // Gera um número de 0 a 4 e seleciona um objeto Pen correspondente.
            return Pens.White;
        }
    }
}
