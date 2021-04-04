using FactoryMethod.Vehicles;
using System;

namespace FactoryMethod.Factories
{
    class BikeTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}
