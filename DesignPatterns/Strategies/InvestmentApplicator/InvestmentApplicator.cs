using System;

namespace DesignPatterns
{
    public class InvestmentApplicator
    {
        public void ApplyInvestment(BankAccount bankAccount, IInvestment investment)
        {
            var result = investment.Apply(bankAccount);
            bankAccount.Deposit(result);
            Console.WriteLine("Novo saldo: " + bankAccount.Balance);
        }
    }
}
