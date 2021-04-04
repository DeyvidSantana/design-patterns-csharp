using Builder.Builders;
using Builder.Components;
using System;

namespace Builder.Directors
{
    class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructSuv()
        {
            builder.SetVehicleType(VehicleType.SUV);
            builder.SetEngine(new Engine(2.6));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
            builder.SetAirbags(new AirBag());
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.MANUAL);
        }
    }
}
