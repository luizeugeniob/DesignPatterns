using System;

namespace DesignPatterns
{
    internal static partial class Program
    {
        public class Moderate : IInvestment
        {
            private readonly Random random;

            public Moderate()
            {
                random = new Random();
            }

            public double Apply(BankAccount bankAccount)
            {
                if (random.Next(2) == 0)
                    return bankAccount.Balance * 0.025;
                else
                    return bankAccount.Balance * 0.007;
            }
        }
    }
}
