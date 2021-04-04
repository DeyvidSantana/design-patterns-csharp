using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server server;

        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@hcode.com.br", "mst12345678");

            server.RegisterUser("user@hcode.com.br", "12345678");

            var middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckWeakPasswordMiddleware());

            server.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            bool done;

            do
            {
                Console.WriteLine("Digite seu e-mail:");

                var email = Console.ReadLine();

                Console.WriteLine("Digite sua senha:");

                var password = Console.ReadLine();

                done = server.Login(email, password);
            } while (!done);

            Console.ReadLine();
        }
    }
}
