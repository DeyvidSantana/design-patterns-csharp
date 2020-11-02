using Design_Patterns_CSharp.Guru.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_CSharp.Guru.Classes
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
