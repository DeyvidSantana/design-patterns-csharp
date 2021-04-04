using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Car();
        }
    }
}
