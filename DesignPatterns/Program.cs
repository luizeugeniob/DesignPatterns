using System;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var reform = new Budget(500);

            Console.WriteLine(reform.Amount);

            reform.ApplyExtraDiscount();
            Console.WriteLine(reform.Amount);

            reform.Approves();

            reform.ApplyExtraDiscount();
            reform.ApplyExtraDiscount();
            Console.WriteLine(reform.Amount);

            reform.Finalize();

            Console.ReadLine();
        }
    }
}
