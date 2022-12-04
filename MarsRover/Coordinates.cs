using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    internal class Coordinates
    {
        private int _x, _y;
        public int X
        {
            get
            {
                return _x;
            }
            set { _x = value; }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set { _y = value; }
        }
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinates(Coordinates coordinates)
        {
            X = coordinates.X;
            Y = coordinates.Y;
        }
    }
}
