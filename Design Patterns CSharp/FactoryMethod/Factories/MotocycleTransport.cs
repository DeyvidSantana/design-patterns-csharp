using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class MotocycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motocycle();
        }
    }
}
