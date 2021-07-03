using System;

namespace Tetris
{
    public class Point
    {
        public int X;
        public int Y;
        public char C;

        //ВАРИАНТ СЕРЕЖИ
        //public int X { get; set; }
        //public int Y { get; set; }
        //public char C { get; set; }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(C);
        }

        public Point(int a, int b, char sym)
        {
            X = a;
            Y = b;
            C = sym;
        }

        public Point() { }
    }
}