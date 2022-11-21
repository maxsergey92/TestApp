using UnitFramework.Abstractions;
using UnitFramework.DefaultCommands;
using UnitFramework.DefaultStates;
using UnitFramework.Interfaces;

namespace UnitFramework.DefaultUnits
{
    public sealed class Tractor : IUnit, IRotation, IMoveForward
    {
        private const double DEFAULT_POSITION_X = 0;
        private const double DEFAULT_POSITION_Y = 0;
        private const double DEFAULT_DIRECTION = 90;

        public PositionState Position { get; private set; }
        public DirectionState Direction { get; private set; }

        public Tractor() : this(DEFAULT_POSITION_X, DEFAULT_POSITION_Y, DEFAULT_DIRECTION)
        { }

        public Tractor(double x, double y, double direction)
        {
            Position = new PositionState(x, y);
            Direction = new DirectionState(direction);
        }

        public string GetStatuses() => $"{Position.StateName}: {Position.GetStatus()};\n{Direction.StateName}: {Direction.GetStatus()}";

        public void Rotate(double degree)
        {
            var command = new RotationCommand();
            command.Rotate(Direction, degree);
        }

        public void MoveForward(double distance)
        {
            var command = new MoveForwardCommand();
            command.MoveForward(Position, Direction, distance);
        }
    }
}
