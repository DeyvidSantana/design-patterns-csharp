using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    abstract class Transport
    {
        public void StartTransport()
        {
            var vehicle = CreateTransport();

            vehicle.StartRoute();
        }

        protected abstract IVehicle CreateTransport();
    }
}
