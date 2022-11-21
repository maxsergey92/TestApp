using System;

using UnitFramework.DefaultStates;

namespace UnitFramework.DefaultCommands
{
    public class RotationCommand
    {
        public virtual void Rotate(DirectionState direction, double degree)
        {
            direction.UpdateDirection(degree);
            Console.WriteLine($"Установлено новое направление {degree}градусов.");
        }
    }
}