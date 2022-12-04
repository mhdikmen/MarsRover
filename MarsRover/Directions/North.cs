using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Directions
{
    internal class North : RoverDirection
    {
        public North(Rover rover) : base(rover)
        {
        }

        public override void MoveForward()
        {
            Coordinates coordinates = _rover.GetCoordinates();
            _rover.SetCoordinates(new Coordinates(coordinates.X, coordinates.Y + 1));
        }

        public override void TurnLeft()
        {
            _rover.SetRoverDirection(new West(_rover));
        }

        public override void TurnRight()
        {
            _rover.SetRoverDirection(new East(_rover));
        }
        public override string ToString()
        {
            return "N";
        }
    }
}
