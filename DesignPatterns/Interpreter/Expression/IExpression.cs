namespace DesignPatterns
{
    public interface IExpression
    {
        int Evaluate();

        void Print(IVisitorPrinter printer);
    }
}
