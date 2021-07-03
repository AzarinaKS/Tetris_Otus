using System;
using System.Security.Cryptography.X509Certificates;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            // ВАРИАНТ СЕРЕЖИ
            //var p1 = new Point
            //{
            //    C = '*',
            //    X = 3,
            //    Y = 5
            //};

            //var p2 = new Point
            //{
            //    C = '*',
            //    X = 6,
            //    Y = 8
            //};

            //p1.Draw();
            //p2.Draw();

            //Point p1 = new Point();
            //p1.Draw();

            // ВАРИАНТ ОТУС

            Point p1 = new Point(2, 3, '*');
            p1.Draw();

            Point p2 = new Point()
            {
                X = 4,
                Y = 5,
                C = '#',
            };
            p2.Draw();

                Console.ReadLine();
        }
    }
}
