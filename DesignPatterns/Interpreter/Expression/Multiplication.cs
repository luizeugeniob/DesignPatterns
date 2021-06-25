namespace DesignPatterns
{
    public class Multiplication : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;

        public Multiplication(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Evaluate()
        {
            return left.Evaluate() * right.Evaluate();
        }
    }
}
