namespace DesignPatterns
{
    public class Sum : IExpression
    {
        public IExpression Left { get; private set; }
        public IExpression Right { get; private set; }

        public Sum(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public int Evaluate()
        {
            return Left.Evaluate() + Right.Evaluate();
        }

        public void Print(IVisitorPrinter printer)
        {
            printer.PrintSum(this);
        }
    }
}
