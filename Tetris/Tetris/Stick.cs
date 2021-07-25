using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Stick : Figure
    {
        public Stick(int X, int Y, char sym)
        {
            points[0] = new Point(X, Y, sym);
            points[1] = new Point(X, Y+1, sym);
            points[2] = new Point(X, Y+2, sym);
            points[3] = new Point(X, Y + 3, sym);
            Draw();
        }

        public override void Rotate(Point[] plist)
        {
            if (plist[0].X == plist[1].X)
            {
                RotateHorisontal(plist);
            }
            else
            {
                RotateVertical(plist);
            }
        }

        private void RotateVertical(Point[] plist)
        {
            for (int i = 0; i < plist.Length; i++)
            {
                plist[i].Y = plist[0].Y+i;
                plist[i].X = plist[0].X;
            }
        }

        private void RotateHorisontal(Point[] plist)
        {
            for (int i = 0; i < plist.Length; i++)
            {
                plist[i].Y = plist[0].Y;
                plist[i].X = plist[0].X + i;
            }
        }
    }
}
