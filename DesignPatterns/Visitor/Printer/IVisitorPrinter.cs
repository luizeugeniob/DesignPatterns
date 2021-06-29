namespace DesignPatterns
{
    public interface IVisitorPrinter
    {
        void PrintSum(Sum sum);
        void PrintSubtraction(Subtraction subtraction);
        void PrintNumber(Number number);
    }
}
