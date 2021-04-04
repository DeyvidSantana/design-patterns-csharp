using System;

namespace AbstractFactory.Landvehicles
{
    class Car : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros, estamos prontos!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
