using TestApp.MyCommands;
using TestApp.MyInterfaces;
using TestApp.MyStates;

using UnitFramework.Abstractions;
using UnitFramework.DefaultCommands;
using UnitFramework.DefaultStates;
using UnitFramework.Interfaces;

namespace TestApp.MyUnits
{
    public class TankUnit : IUnit, IFire, IRotation, IMoveForward
    {
        private const double DEFAULT_POSITION_X = 0;
        private const double DEFAULT_POSITION_Y = 0;
        private const double DEFAULT_DIRECTION = 90;
        private const int DEFAULT_AMMO = 15;

        public PositionState Position { get; }
        public DirectionState Direction { get; }
        public AmmoState Ammo { get; }

        public TankUnit() : this(DEFAULT_POSITION_X, DEFAULT_POSITION_Y, DEFAULT_DIRECTION, DEFAULT_AMMO)
        { }

        public TankUnit(double x, double y, double direction, int ammo)
        {
            Position = new PositionState(x, y);
            Direction = new DirectionState(direction);
            Ammo = new AmmoState(ammo);
        }

        public string GetStatuses() => $"{Position.StateName}: {Position.GetStatus()};\n{Direction.StateName}: {Direction.GetStatus()};\n{Ammo.StateName}: {Ammo.GetStatus()}";

        public void Fire(int shotCount)
        {
            var command = new FireCommand();
            command.Fire(Ammo, shotCount);
        }

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
