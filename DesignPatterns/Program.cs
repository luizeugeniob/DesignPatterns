using System;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var left = new Sum(new Sum(new Number(1), new Number(100)), new Number(10));
            var right = new Subtraction(new Number(20), new Number(10));
            var result = new Sum(left, right);

            Console.WriteLine(result.Evaluate());

            var printer = new WeirdoVisitorPrinter();
            result.Print(printer);
        }
    }
}
