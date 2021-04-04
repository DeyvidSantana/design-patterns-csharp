using FactoryMethod.Factories;
using System;

namespace FactoryMethod
{
    class Program
    {
        private static Transport transport = null;

        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "--uber")
            {
                transport = new CarTransport();
            }
            else if (args.Length > 0 && args[0] == "--log")
            {
                transport = new MotocycleTransport();
            }
            else if (args.Length > 0 && args[0] == "--eats")
            {
                transport = new BikeTransport();
            }
            else
                    {
                Console.WriteLine("Selecione o tipo de serviço.");
            }

            if(transport != null)
            {
                transport.StartTransport();
            }

            Console.ReadLine();
        }
    }
}
