using System;

using UnitFramework.DefaultStates;

namespace UnitFramework.DefaultCommands
{
    public class MoveForwardCommand
    {
        public virtual void MoveForward(PositionState position, DirectionState direction, double distance)
        {
            var newX = position.XCoord + distance * Math.Round(Math.Cos(GetRadian(direction.Direction)), 1);
            var newY = position.YCoord + distance * Math.Round(Math.Sin(GetRadian(direction.Direction)), 1);
            position.UpdateCoords(newX, newY);
            Console.WriteLine($"Выполнено движение на {distance}м вперед с направлением {direction.Direction}градусов.");

            return;

            static double GetRadian(double gradus)
            {
                return gradus * Math.PI / 180;
            }
        }
    }
}
