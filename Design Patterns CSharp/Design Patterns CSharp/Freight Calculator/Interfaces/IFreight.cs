using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_CSharp.CalculadorFretes.Interfaces
{
    public interface IFreight
    {
        public double CalculatePrice(int distancia);
    }
}
