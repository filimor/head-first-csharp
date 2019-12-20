using System;
using System.Collections.Generic;
using System.Drawing;

namespace SpaceInvaders
{
    public class Stars
    {
        private Rectangle _boundaries;

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
        private List<Star> StarsOnScreen { get; }

        /// <summary>
        /// Povoa a lista de estrelas.
        /// </summary>
        /// <param name="boundaries">Rectangle com os limites de exibição.</param>
        /// <param name="random">Instância de Random para criá-las em posições aleatórias.</param>
        public Stars(Rectangle boundaries, Random random)
        {
            _boundaries = boundaries;
            StarsOnScreen = new List<Star>();
            for (int i = 0; i < 300; i++)
            {
                int x = random.Next(boundaries.Width);
                int y = random.Next(boundaries.Height);
                StarsOnScreen.Add(new Star(new Point(x, y), RandomPen(random)));
            }
        }

        public void Draw(Graphics g)
        {
            for (int i = 0; i < 300; i++)
            {
                g.DrawEllipse(StarsOnScreen[i].Pen, StarsOnScreen[i].Point.X, StarsOnScreen[i].Point.Y, 2, 2);
            }
        }

        /// <summary>
        /// Remove cinco estrelas em posições aleatórias e adiciona cinco novas.
        /// </summary>
        /// <param name="random">Instância de Random.</param>
        public void Twinkle(Random random)
        {
            for (int i = 0; i < 5; i++)
            {
                StarsOnScreen.RemoveAt(i);
            }
            for (int i = 0; i < 5; i++)
            {
                int x = random.Next(_boundaries.Width);
                int y = random.Next(_boundaries.Height);
                StarsOnScreen.Add(new Star(new Point(x, y), RandomPen(random)));
            }
        }

        /// <summary>
        /// Dá uma cor aleatória às estrelas quando criadas.
        /// </summary>
        /// <returns>Retorna uma das cinco cores possíveis.</returns>
        private Pen RandomPen(Random random)
        {
            // Gera um número de 0 a 4 e seleciona um objeto Pen correspondente.
            switch (random.Next(5))
            {
                case 0:
                    return Pens.Aquamarine;

                case 1:
                    return Pens.LightCoral;

                case 2:
                    return Pens.DarkGreen;

                case 3:
                    return Pens.OrangeRed;

                case 4:
                    return Pens.DarkViolet;
            }

            return null;
        }
    }
}