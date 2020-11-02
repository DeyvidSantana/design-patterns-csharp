using Design_Patterns_CSharp.Guru.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_CSharp.Guru.Classes
{
    public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
