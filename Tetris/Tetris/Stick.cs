using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Stick : Figure
    {
        public Stick(int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y+1, sym);
            points[2] = new Point(x, y+2, sym);
            points[3] = new Point(x, y + 3, sym);
        }

        public override void Rotate()
        {
            if (points[0].X == points[1].X)
            {
                RotateHorisontal();
            }
            else
            {
                RotateVertical();
            }
        }

        private void RotateVertical()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].Y = points[0].Y+i;
                points[i].X = points[0].X;
            }
        }

        private void RotateHorisontal()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].Y = points[0].Y;
                points[i].X = points[0].X + i;
            }
        }
    }
}
