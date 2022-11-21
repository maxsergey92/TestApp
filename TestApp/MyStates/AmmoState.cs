namespace TestApp.MyStates
{
    public class AmmoState
    {
        public string StateName { get; } = "Боезапас";
        public int AmmoCount { get; private set; }

        public AmmoState(int ammoCount)
        {
            AmmoCount = ammoCount;
        }

        public void UpdateAmmo(int newValue)
        {
            AmmoCount = newValue;
        }

        public string GetStatus() => $"Осталось {AmmoCount}шт.";
    }
}
