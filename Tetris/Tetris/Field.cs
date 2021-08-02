using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    static class Field
    {

        public static int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                Console.SetWindowSize(Field._width, Field._height);
                Console.SetBufferSize(Field._width, Field._height);
            }
        }

        public static int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                Console.SetWindowSize(Field._width, Field._height);
                Console.SetBufferSize(Field._width, Field._height);
            }
        }

        private static int _width = 40;
        private static int _height = 30;

        private static bool[][] _heap;

        static Field()
        {
            _heap = new bool[Height][];
            for(int i=0; i < Height; i++)
            {
                _heap[i] = new bool[Width];
            }
        }

        public static bool CheckStrike(Point p)
        {
            return _heap[p.Y][p.X];
        }
        public static void AddFigure(Figure fig)
        {
            foreach (var p in fig.Points)
            {
                _heap[p.Y][p.X] = true;
            }
        }

    }
}
