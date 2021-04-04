using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.App
{
    class Application
    {
        private IAircraft aircraft;
        private ILandvehicle vehicle;

        public Application(ITransportFactory factory)
        {
            aircraft = factory.CreateTransportAircraft();
            vehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            aircraft.StartRoute();
            vehicle.StartRoute();
        }
    }
}
