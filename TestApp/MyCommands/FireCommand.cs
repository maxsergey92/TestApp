using System;

using TestApp.MyStates;

namespace TestApp.MyCommands
{
    public class FireCommand
    {
        public virtual void Fire(AmmoState ammo, int shotCount)
        {
            if (ammo.AmmoCount == 0)
                Console.WriteLine("Выстрел не выполнен: боезапас пуст!");

            var ammoLeft = ammo.AmmoCount - shotCount;
            if (ammoLeft <= 0)
            {
                ammo.UpdateAmmo(0);
                Console.WriteLine($"Выполнен выстрел в кол-ве {Math.Abs(ammoLeft)}шт. Боезапас пуст!");
            }
            else
            {
                ammo.UpdateAmmo(ammoLeft);
                Console.WriteLine($"Выполнен выстрел в кол-ве {shotCount}шт. ");
            }
        }
    }
}
