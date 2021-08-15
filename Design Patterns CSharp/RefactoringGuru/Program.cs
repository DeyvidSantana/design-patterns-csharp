using RefactoringGuru.Criacionais;
using RefactoringGuru.Estruturais;
using System;
using System.Threading;

namespace RefactoringGuru
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        #region Criacionais

        #region Singleton

        private static void ExecutarSingletonIngenuo()
        {
            var s1 = SingletonIngenuo.ObterInstancia();
            var s2 = SingletonIngenuo.ObterInstancia();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton funciona, ambas variáveis contém a mesma instância");
            }
            else
            {
                Console.WriteLine("Singleton falhou, variáveis contém instâncias diferentes");
            }
        }

        private static void ExecutarSingletonSeguroThreads()
        {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n", 
                "Se você ver o mesmo valor, então o Singleton foi reusado (yay!)",
                "Se você ver diferentes valores, então 2 singletons foram criados (booo!!)", 
                "RESULTADO:");

            var processo1 = new Thread(() =>
            {
                TestarSingleton("FOO");
            });

            var processo2 = new Thread(() =>
            {
                TestarSingleton("BAR");
            });

            processo1.Start();
            processo2.Start();

            processo1.Join();
            processo2.Join();
        }

        private static void TestarSingleton(string valor)
        {
            var singleton = SingletonSeguroThreads.ObterInstancia(valor);
            Console.WriteLine(singleton.Valor);
        }

        #endregion

        #endregion

        #region Estruturais

        #region Adapter

        private static void ExecutarAdapter()
        {
            var adaptee = new Adaptee();
            var target = new Adapter(adaptee);

            Console.WriteLine("Interface adaptee é incompatível com o cliente.");
            Console.WriteLine("Mas com o adaptador o cliente consegue chamar seu método.");

            Console.WriteLine(target.ObterRequisicao());
        }

        #endregion

        #endregion
    }
}
