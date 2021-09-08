using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Stick : Figure
    {
        public Stick(int X, int Y, char sym)
        {
            Points[0] = new Point(X, Y, sym);
            Points[1] = new Point(X, Y+1, sym);
            Points[2] = new Point(X, Y+2, sym);
            Points[3] = new Point(X, Y + 3, sym);
            Draw();
        }

        public override void Rotate()
        {
            if (Points[0].X == Points[1].X)
            {
                RotateHorisontal();
            }
            else
            {
                RotateVertical();
            }
        }

        private void RotateHorisontal()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].Y = Points[0].Y;
                Points[i].X = Points[0].X + i;
            }
        }

        private void RotateVertical()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].Y = Points[0].Y+i;
                Points[i].X = Points[0].X;
            }
        }

    }
}
