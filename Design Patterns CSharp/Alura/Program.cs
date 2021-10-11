using Alura.ChainOfResponsability;
using System;

namespace Alura
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteChainOfResponsability();
        }

        private static void ExecuteChainOfResponsability()
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            Orcamento orcamento = new Orcamento(500.0);

            double desconto = d1.Desconta(orcamento);
            Console.WriteLine(desconto);
        }
    }
}
