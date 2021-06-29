namespace DesignPatterns
{
    public class Number : IExpression
    {
        public int Value { get; private set; }

        public Number(int number)
        {
            Value = number;
        }

        public int Evaluate()
        {
            return Value;
        }

        public void Print(IVisitorPrinter printer)
        {
            printer.PrintNumber(this);
        }
    }
}
