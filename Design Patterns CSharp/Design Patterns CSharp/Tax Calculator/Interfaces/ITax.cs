using Design_Patterns_CSharp.CalculadorImpostos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_CSharp.CalculadorImpostos.Interfaces
{
    public interface ITax
    {
        double Calculate(Budget orcamento);
    }
}
