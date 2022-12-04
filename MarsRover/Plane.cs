namespace MarsRover
{
    internal class Plane
    {
        private readonly Coordinates _minCoordinates;
        private readonly Coordinates _maxCoordinates;

        public Plane(Coordinates minCoordinates, Coordinates maxCoordinates)
        {
            _minCoordinates = minCoordinates;
            _maxCoordinates = maxCoordinates;
        }

        public Coordinates SetIfCoordinatesExceedsPlane(Coordinates coordinates)
        {
            Coordinates copy = new Coordinates(coordinates);
            if (copy.X < _minCoordinates.X)
                copy.X = _maxCoordinates.X;

            if (copy.Y < _minCoordinates.Y)
                copy.Y = _minCoordinates.Y;

            if (copy.X > _maxCoordinates.X)
                copy.X = _maxCoordinates.X;

            if (copy.Y > _maxCoordinates.Y)
                copy.Y = _maxCoordinates.Y;
            return copy;
        }
    }
}
