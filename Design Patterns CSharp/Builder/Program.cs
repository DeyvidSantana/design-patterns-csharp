using Builder.Builders;
using Builder.Directors;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new VehicleBuilder();
            var director = new Director(builder);

            director.ConstructSedanCar();

            var sedan = builder.GetVehicle();

            Console.WriteLine($"Criando um veículo do tipo: {sedan.VehicleType}");

            director.ConstructSuv();

            var suv = builder.GetVehicle();

            Console.WriteLine($"Criando um veículo do tipo: {suv.VehicleType}");
        }
    }
}
