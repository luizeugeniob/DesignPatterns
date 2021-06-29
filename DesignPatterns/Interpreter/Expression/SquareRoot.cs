using System;

namespace DesignPatterns
{
    public class SquareRoot : IExpression
    {
        private readonly IExpression expression;

        public SquareRoot(IExpression expression)
        {
            this.expression = expression;
        }

        public int Evaluate()
        {
            return (int)Math.Sqrt(expression.Evaluate());
        }

        public void Print(IVisitorPrinter printer)
        {
            throw new NotImplementedException();
        }
    }
}
