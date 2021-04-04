using System;

namespace Bridge.Platforms
{
    class Facebook : IPlatform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: configurando servidor RMTP.");
        }
    }
}
