using System;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var icms = new Icms();
            var iss = new Iss();

            var budget = new Budget(500.0);

            var taxCalculator = new TaxCalculator();

            taxCalculator.Calculate(budget, icms);
            taxCalculator.Calculate(budget, iss);

            Console.ReadLine();
        }
    }
}
