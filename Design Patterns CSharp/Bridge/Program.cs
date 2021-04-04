using Bridge.Platforms;
using Bridge.Transmissions;
using System;

namespace Bridge
{
    class Program
    {
        private static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            var live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        private static void StartAdvancedLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            var live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.Result();
        }

        static void Main(string[] args)
        {
            StartAdvancedLive(new Youtube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());
            StartAdvancedLive(new DLive());

            Console.ReadLine();
        }
    }
}
