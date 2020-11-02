using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_CSharp.CalculadorImpostos
{
    public class Budget
    {
        public double Amount { get; private set; }

        public Budget(double amount)
        {
            Amount = amount;
        }
    }
}
