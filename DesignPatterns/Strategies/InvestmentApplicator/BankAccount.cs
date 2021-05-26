namespace DesignPatterns
{
    internal static partial class Program
    {
        public class BankAccount
        {
            public double Balance { get; private set; }

            public void DepositsValue(double amount)
            {
                Balance += amount;
            }
        }
    }
}
