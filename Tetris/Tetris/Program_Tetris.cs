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

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure s = null;

            while (true)
            {
                FigureFall(ref s, generator);
                s.Draw();
            }

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
        }

        static void FigureFall(ref Figure fig, FigureGenerator generator)
        {
            fig = generator.GetNewFigure();
            fig.Draw();

            for (int i = 0; i < 20; i++)
            {
                fig.Hide();
                fig.Move(Direction.DOWN);
                fig.Draw();
                Thread.Sleep(250);
            }
        }

    }
}
