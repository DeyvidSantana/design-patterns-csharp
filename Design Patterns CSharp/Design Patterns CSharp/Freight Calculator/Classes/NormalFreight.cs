using Design_Patterns_CSharp.CalculadorFretes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_CSharp.CalculadorFretes.Classes
{
    public class NormalFreight : IFreight
    {
        public double CalculatePrice(int distancia)
        {
            return distancia * 1.25 + 10;
        }
    }
}
