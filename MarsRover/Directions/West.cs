using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Directions
{
    internal class West : RoverDirection
    {
        public West(Rover rover) : base(rover)
        {
        }

        public override void MoveForward()
        {
            Coordinates coordinates = _rover.GetCoordinates();
            _rover.SetCoordinates(new Coordinates(coordinates.X - 1, coordinates.Y));
        }

        public override void TurnLeft()
        {
            _rover.SetRoverDirection(new South(_rover));
        }

        public override void TurnRight()
        {
            _rover.SetRoverDirection(new North(_rover));
        }

        public override string ToString()
        {
            return "W";
        }
    }
}
