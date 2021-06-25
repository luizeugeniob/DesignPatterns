namespace DesignPatterns
{
    public class Sum : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;

        public Sum(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Evaluate()
        {
            return left.Evaluate() + right.Evaluate();
        }
    }
}
