using Alura.ChainOfResponsability;
using Alura.TemplateMethod;
using System;

namespace Alura
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteTemplateMethod();
        }

        private static void ExecuteTemplateMethod()
        {
            var icpp = new ICPP();
            var ikcv = new IKCV();

            var valorImpostoIcpp = icpp.Calcular(new Orcamento(500.0));
            var valorImpostoIkcv = ikcv.Calcular(new Orcamento(500.0));

            Console.WriteLine(valorImpostoIcpp);
            Console.WriteLine(valorImpostoIkcv);
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
