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

        internal Result TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);

            var result = VerifyPosition(clone);
            if (result ==Result.SUCCESS)
                Points = clone;

            Draw();

            return result;
        }

        internal Result TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;

            Draw();
            return result;
        }

        private Result VerifyPosition(Point[] newPoints)
        {
            foreach (var p in newPoints)
            {
                if (p.Y >= Field.Height)
                    return Result.DOWN_BORDER_STRIKE;

                if (p.X >= Field.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;

                if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;
            }
            return Result.SUCCESS;
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
