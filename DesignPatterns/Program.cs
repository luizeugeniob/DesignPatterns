using System;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var tax = new Iss(new Icms());

            var budget = new Budget(500);

            var amount = tax.Calculate(budget);

            Console.WriteLine(amount);

            Console.ReadLine();
        }
    }
}
