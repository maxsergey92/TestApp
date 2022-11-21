namespace UnitFramework.DefaultStates
{
    public class PositionState
    {
        public string StateName { get; } = "Позиция";
        public double XCoord { get; private set; }

        public double YCoord { get; private set; }

        public PositionState(double startPosX, double startPosY)
        {
            XCoord = startPosX;
            YCoord = startPosY;
        }

        public void UpdateCoords(double newX, double newY)
        {
            XCoord = newX;
            YCoord = newY;
        }

        public string GetStatus() => $"Координата Х = {XCoord}; Координата Y = {YCoord}";
    }
}
