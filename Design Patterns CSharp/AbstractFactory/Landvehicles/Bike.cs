using System;

namespace AbstractFactory.Landvehicles
{
    class Bike : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando as encomendas por bicicleta.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
