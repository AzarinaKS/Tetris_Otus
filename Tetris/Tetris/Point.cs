using System;

namespace Tetris
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char C { get; set; }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(C);
        }

    }
}