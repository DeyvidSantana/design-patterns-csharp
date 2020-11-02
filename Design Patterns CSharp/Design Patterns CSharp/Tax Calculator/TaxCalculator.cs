using Design_Patterns_CSharp.CalculadorImpostos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_CSharp.CalculadorImpostos
{
    public class TaxCalculator
    {
        public void PerformCalculation(Budget budget, ITax tax)
        {
            var taxCalculation = tax.Calculate(budget);
            Console.WriteLine(taxCalculation);
        }
    }
}
