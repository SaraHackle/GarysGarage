using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)

        {
            Zero fxs = new Zero()
            {
                BatteryKWh = 7.2,
                MainColor = "Black",
                MaximumOccupancy = 2
            };
            Tesla modelS = new Tesla()
            {
                BatteryKWh = 100,
                MainColor = "White",
                MaximumOccupancy = 5
            };
            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 53,
                MainColor = "Blue",
                MaximumOccupancy = 4
            };
             Ram rebel = new Ram()
            {
                FuelCapacity = 26,
                MainColor = "Red",
                MaximumOccupancy = 6
            };

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            Console.WriteLine();
            
            rebel.Drive();
            rebel.Turn();
            rebel.Stop();
        }

    }
}
