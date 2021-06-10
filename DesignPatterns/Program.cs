using System;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var tax = new Ikcv(new Icpp());

            var budget = new Budget(500);

            var amount = tax.Calculate(budget);

            Console.WriteLine(amount);

            Console.ReadLine();
        }
    }
}
