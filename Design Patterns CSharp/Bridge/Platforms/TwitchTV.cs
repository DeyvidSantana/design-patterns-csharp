using System;

namespace Bridge.Platforms
{
    class TwitchTV : IPlatform
    {
        public TwitchTV()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTV: transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("TwitchTV: autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTV: configurando servidor RMTP.");
        }
    }
}
