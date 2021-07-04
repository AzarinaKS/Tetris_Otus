using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Tetris
{
    class Program_Tetris
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

            Square s = new Square(2, 5, '*');
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.LEFT);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();



            //Stick st = new Stick(4, 8, '#');
            //st.Draw();


            //Point p1 = new Point(2, 3, '*');
            //p1.Draw();

            //Point p2 = new Point()
            //{
            //    X = 4,
            //    Y = 5,
            //    C = '#',
            //};
            //p2.Draw();


            Console.ReadLine();
        }
    }
}
