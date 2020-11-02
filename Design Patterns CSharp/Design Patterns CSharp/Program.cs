using System;

namespace Design_Patterns_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############## TAX CALCULATOR #############");
            ExempleTaxCalculator.Execute();

            Console.WriteLine("############## FREIGHT CALCULATOR #############");
            ExempleFreightCalculator.Execute();

            Console.WriteLine("############## REFACTORING GURU ##############");
            ExempleRefactoringGuru.Execute();
        }
    }
}
