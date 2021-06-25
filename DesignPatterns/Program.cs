using System;
using System.Linq.Expressions;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var left = new Sum(new Sum(new Number(1), new Number(100)), new Number(10));
            var right = new Subtraction(new Number(20), new Number(10));
            var multiplication = new Multiplication(left, right);
            var result = new SquareRoot(multiplication);

            Console.WriteLine(result.Evaluate());

            //Exemplo de Interpreter do próprio C#
            Expression expression = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            var function = Expression.Lambda<Func<int>>(expression).Compile();
            Console.WriteLine(function());
        }
    }
}
