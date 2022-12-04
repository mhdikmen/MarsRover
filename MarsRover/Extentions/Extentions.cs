using MarsRover.Directions;
using System;

namespace MarsRover.Extentions
{
    internal static class Extentions
    {
        public static RoverDirection GetRoverDirection(this Rover rover, string direction)
        {
            RoverDirection roverDirection = direction switch
            {
                "N" => new North(rover),
                "E" => new East(rover),
                "S" => new South(rover),
                "W" => new West(rover),
                _ => throw new ArgumentOutOfRangeException($"The direction you entered is not allowed. Input : {direction}"),
            };
            return roverDirection;
        }
    }
}
