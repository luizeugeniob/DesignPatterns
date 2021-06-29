using System;

namespace DesignPatterns
{
    public class Division : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;

        public Division(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Evaluate()
        {
            return left.Evaluate() / right.Evaluate();
        }

        public void Print(IVisitorPrinter printer)
        {
            throw new NotImplementedException();
        }
    }
}
