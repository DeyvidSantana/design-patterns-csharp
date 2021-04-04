using System;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checando os ventos.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegando as encomendas.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem.");
        }
    }
}
