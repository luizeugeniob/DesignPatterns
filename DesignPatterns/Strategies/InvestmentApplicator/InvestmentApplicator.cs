using System;

namespace DesignPatterns
{
    internal static partial class Program
    {
        public class InvestmentApplicator
        {
            public void ApplyInvestment(BankAccount bankAccount, IInvestment investment)
            {
                var result = investment.Apply(bankAccount);
                bankAccount.DepositsValue(result);
                Console.WriteLine("Novo saldo: " + bankAccount.Balance);
            }
        }
    }
}
