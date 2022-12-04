using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    internal abstract class RoverDirection
    {
        protected Rover _rover;

        public RoverDirection(Rover rover)
        {
            _rover = rover;
        }

        public abstract void TurnRight();
        public abstract void TurnLeft();

        public abstract void MoveForward();
    }
}
