using System;

using TestApp.MyUnits;

namespace TestApp
{
    class Program
    {
        static void Main()
        {
            var tr = new TankUnit();
            tr.Fire(1);
            Console.WriteLine(tr.GetStatuses());
            Console.ReadKey();
        }
    }
}
