using System;

namespace FactoryMethod.Vehicles
{
    class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos as marmitas!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos o trajeto.");
        }
    }
}
