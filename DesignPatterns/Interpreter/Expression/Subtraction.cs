namespace DesignPatterns
{
    public class Subtraction : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;

        public Subtraction(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Evaluate()
        {
            return left.Evaluate() - right.Evaluate();
        }
    }
}
