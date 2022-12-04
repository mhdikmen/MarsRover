using System;
using System.Linq;

namespace MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordinates minCoordinates = new Coordinates(0, 0);

            Console.WriteLine("Enter the top right corner coordinates of the plane :");
            var topRightCoordinates = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Enter the coordinates of the first rover and direction :");
            var firstRoverInfo = Console.ReadLine().Split(" ").ToArray();

            Console.WriteLine("Enter the first rover command :");
            string firstCommand = Console.ReadLine();

            Console.WriteLine("Enter the coordinates of the second rover and direction :");
            var secondRoverInfo = Console.ReadLine().Split(" ").ToArray();

            Console.WriteLine("Enter the second rover command :");
            string secondCommand = Console.ReadLine();


            Coordinates maxCoordinates = new Coordinates(topRightCoordinates[0], topRightCoordinates[1]);
            Plane plane = new Plane(minCoordinates, maxCoordinates);

            Rover firstRover = new Rover(new Coordinates(int.Parse(firstRoverInfo[0]), int.Parse(firstRoverInfo[1])), firstRoverInfo[2], plane);
            firstRover.RunCommand(firstCommand);
            Console.WriteLine(firstRover);

            Rover secondRover = new Rover(new Coordinates(int.Parse(secondRoverInfo[0]), int.Parse(secondRoverInfo[1])), secondRoverInfo[2], plane);
            firstRover.RunCommand(secondCommand);
            Console.WriteLine(secondRover);

            Console.ReadKey();
        }
    }
}
