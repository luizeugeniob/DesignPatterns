using System;

namespace DesignPatterns
{
    internal static partial class Program
    {
        public class Bold : IInvestment
        {
            private readonly Random random;

            public Bold()
            {
                random = new Random();
            }

            public double Apply(BankAccount bankAccount)
            {
                int kick = random.Next(10);

                if (kick >= 0 && kick <= 1)
                {
                    return bankAccount.Balance * 0.5;
                }
                else if (kick >= 2 && kick <= 4)
                {
                    return bankAccount.Balance * 0.3;
                }
                else
                {
                    return bankAccount.Balance * 0.006;
                }
            }
        }
    }
}
