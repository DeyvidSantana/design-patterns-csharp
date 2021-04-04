using System;

namespace Bridge.Platforms
{
    class DLive : IPlatform
    {
        public DLive()
        {
            ConfigureRMTP();
            Console.WriteLine("DLive: transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("DLive: autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("DLive: configurando servidor RMTP.");
        }
    }
}
