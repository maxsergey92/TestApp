using UnitFramework.Abstractions;
using UnitFramework.DefaultStates;

namespace UnitFramework.DefaultUnits
{
    public class Stone : IUnit
    {
        private const double DEFAULT_POSITION_X = 0;
        private const double DEFAULT_POSITION_Y = 0;

        public PositionState Position { get; private set; }

        public Stone() : this(DEFAULT_POSITION_X, DEFAULT_POSITION_Y) { }

        public Stone(double x, double y)
        {
            Position = new PositionState(x, y);
        }

        public string GetStatuses() => $"{Position.StateName}: {Position.GetStatus()}";
    }
}
