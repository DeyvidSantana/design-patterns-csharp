using Design_Patterns_CSharp.CalculadorImpostos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_CSharp.CalculadorImpostos.Classes
{
    public class ICMS : ITax
    {
        public double Calculate(Budget orcamento)
        {
            return orcamento.Amount * 0.1;
        }
    }
}
