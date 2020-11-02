using Design_Patterns_CSharp.CalculadorImpostos;
using Design_Patterns_CSharp.CalculadorImpostos.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_CSharp
{
    public class ExempleTaxCalculator
    {
        public static void Execute()
        {
            var iss = new ISS();
            var icms = new ICMS();

            var budget = new Budget(500.0);

            var taxCalculator = new TaxCalculator();

            Console.Write("ISS: ");
            taxCalculator.PerformCalculation(budget, iss);
            Console.Write("ICMS: ");
            taxCalculator.PerformCalculation(budget, icms);
        }
    }
}
