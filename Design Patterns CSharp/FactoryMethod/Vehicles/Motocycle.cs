using System;

namespace FactoryMethod.Vehicles
{
    class Motocycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a entrega.");
        }
    }
}
