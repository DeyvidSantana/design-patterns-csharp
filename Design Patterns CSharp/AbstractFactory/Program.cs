using AbstractFactory.App;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory = null;
            string company = "Lime";

            if(company == "Uber")
            {
                transportFactory = new UberTransport();
            } else if(company == "99")
            {
                transportFactory = new NineNineTransport();
            } else
            {
                transportFactory = new LimeTransport();
            }

            app = new Application(transportFactory);

            return app;
        }

        static void Main(string[] args)
        {
            var app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}
