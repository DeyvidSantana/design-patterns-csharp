using Design_Patterns_CSharp.CalculadorFretes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_CSharp.CalculadorFretes.Classes
{
    public class SEDEXFreight : IFreight
    {
        public double CalculatePrice(int distancia)
        {
            return distancia * 1.45 + 12;
        }
    }
}
