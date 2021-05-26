namespace DesignPatterns
{
    internal static partial class Program
    {
        public class Conservative : IInvestment
        {
            public double Apply(BankAccount bankAccount)
            {
                return bankAccount.Balance * 0.008;
            }
        }
    }
}
