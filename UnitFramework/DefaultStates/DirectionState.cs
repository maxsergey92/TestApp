using System;

namespace UnitFramework.DefaultStates
{
    public class DirectionState
    {
        public string StateName { get; } = "Направление";
        public double Direction { get; private set; }

        public DirectionState(double startDegree)
        {
            Direction = startDegree;
        }

        public void UpdateDirection(double newVal)
        {
            Direction = newVal;
        }
        public string GetStatus() => $"{Direction} градусов";
    }
}
