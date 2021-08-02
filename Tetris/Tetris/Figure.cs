using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public abstract class Figure
    {
        const int LENGTH = 4;
        public Point[] Points = new Point[LENGTH];

        public void Draw()
        {
            foreach (Point p in Points)
            {
                p.Draw();
            }
        }

        internal void TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);

            if (VerifyPosition(clone))
                Points = clone;

            Draw();
        }

        internal void TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            if (VerifyPosition(clone))
                Points = clone;

            Draw();
        }

        private bool VerifyPosition(Point[] plist)
        {
            foreach (var p in plist)
            {
                if (p.X < 0 || p.Y < 0 || p.X >= Field.Width || p.Y >= Field.Height)
                    return false;
            }
            return true;
        }


        private Point[] Clone()
        {
            var newPoints = new Point[LENGTH];
            for (int i = 0; i < LENGTH; i++)
            {
                newPoints[i] = new Point(Points[i]);
            }

            return newPoints;
        }

        public void Move(Point[] plist, Direction dir)
        {
            foreach (var p in plist)
            {
                p.Move(dir);
            }
        }



        //public void Move(Direction dir)
        //{
        //    Hide();
        //    foreach (Point p in points)
        //    {
        //        p.Move(dir);
        //    }
        //    Draw();
        //}
        public void Hide()
        {
            foreach (Point p in Points)
            {
                p.Hide();
            }
        }

        public abstract void Rotate(Point[] plist);

    }
}
