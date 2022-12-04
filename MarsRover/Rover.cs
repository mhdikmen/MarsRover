using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Extentions;

namespace MarsRover
{
    internal class Rover
    {
        /// <summary>
        /// Keeps cartesian coordinates
        /// </summary>
        private Coordinates _coordinates;
        private string _direction;
        private Plane _plane;
        private RoverDirection _roverDirection;

        public Rover(Coordinates coordinates, string direction, Plane plane)
        {
            _coordinates = coordinates;
            _direction = direction;
            _plane = plane;
            _roverDirection = this.GetRoverDirection(_direction);
        }

        public Coordinates GetCoordinates()
        {
            return _coordinates;
        }

        public void SetCoordinates(Coordinates coordinates)
        {
            _coordinates = _plane.SetIfCoordinatesExceedsPlane(coordinates); ;
        }

        public void SetRoverDirection(RoverDirection roverDirection)
        {
            this._roverDirection = roverDirection;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", _coordinates.X, _coordinates.Y, _roverDirection);
        }

        public void RunCommand(string roverCommand)
        {
            char[] instructions = roverCommand.ToCharArray();
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L': _roverDirection.TurnLeft(); break;
                    case 'R': _roverDirection.TurnRight(); break;
                    case 'M': _roverDirection.MoveForward(); break;
                    default: throw new ArgumentOutOfRangeException($"Invalid command. Input : {roverCommand}");
                }
            }
        }
    }
}