using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            var p1 = new Point
            {
                C = '*',
                X = 3,
                Y = 5
            };

            var p2 = new Point
            {
                C = '*',
                X = 6,
                Y = 8
            };

            p1.Draw();
            p2.Draw();

            Console.ReadLine();

        }
    }
}
