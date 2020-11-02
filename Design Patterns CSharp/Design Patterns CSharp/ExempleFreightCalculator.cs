using Design_Patterns_CSharp.CalculadorFretes.Classes;
using Design_Patterns_CSharp.CalculadorFretes.Interfaces;
using System;
using System.Collections.Generic;

namespace Design_Patterns_CSharp
{
    public class ExempleFreightCalculator
    {
        public static void Execute()
        {
            Console.WriteLine("Inform the distance: ");
            var distancia = Console.ReadLine();
            Console.WriteLine("Quich the freight's type? (1) Normal, (2) SEDEX");
            var freightOption = Console.ReadLine();
            var freightType = (FreightType)Convert.ToInt32(freightOption);

            var freight = GetFreight(freightType);

            var price = freight.CalculatePrice(Convert.ToInt32(distancia));
            Console.Write("Freight's price: R$ ");
            Console.WriteLine(price);
        }

        public static IFreight GetFreight(FreightType freightType)
        {
            var dictionaryFreights = new Dictionary<FreightType, IFreight>
            {
                { FreightType.NORMAL, new NormalFreight() },
                { FreightType.SEDEX, new SEDEXFreight() }
            };

            return dictionaryFreights[freightType];
        }
    }
}
