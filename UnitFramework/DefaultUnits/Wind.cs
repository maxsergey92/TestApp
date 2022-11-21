using UnitFramework.Abstractions;
using UnitFramework.DefaultCommands;
using UnitFramework.DefaultStates;
using UnitFramework.Interfaces;

namespace UnitFramework.DefaultUnits
{
    public class Wind : IUnit, IRotation
    {
        private const double DEFAULT_DIRECTION = 0;

        public Wind() : this(DEFAULT_DIRECTION) { }

        public Wind(double direction)
        {
            Direction = new DirectionState(direction);
        }

        public DirectionState Direction { get; private set; }

        public string GetStatuses() => $"{Direction.StateName}: {Direction.GetStatus()}";

        public void Rotate(double degree)
        {
            var command = new RotationCommand();
            command.Rotate(Direction, degree);
        }
    }
}
