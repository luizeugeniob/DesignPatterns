namespace DesignPatterns
{
    public class Subtraction : IExpression
    {
        public IExpression Left { get; private set; }
        public IExpression Right { get; private set; }

        public Subtraction(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public int Evaluate()
        {
            return Left.Evaluate() - Right.Evaluate();
        }

        public void Print(IVisitorPrinter printer)
        {
            printer.PrintSubtraction(this);
        }
    }
}
