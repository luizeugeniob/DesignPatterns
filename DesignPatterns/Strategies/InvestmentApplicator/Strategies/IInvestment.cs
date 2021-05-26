namespace DesignPatterns
{
    internal static partial class Program
    {
        public interface IInvestment
        {
            double Apply(BankAccount bankAccount);
        }
    }
}
