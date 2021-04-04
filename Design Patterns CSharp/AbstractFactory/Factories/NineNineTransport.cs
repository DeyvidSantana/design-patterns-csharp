using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;
using System;

namespace AbstractFactory.Factories
{
    class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Motocycle();
        }
    }
}
