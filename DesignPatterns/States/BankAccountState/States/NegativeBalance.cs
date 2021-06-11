using System;

namespace DesignPatterns
{
    public class NegativeBalance : IBankAccountState
    {
        public void Deposit(BankAccount bankAccount, double amount)
        {
            bankAccount.Balance += amount * 0.95;

            if (bankAccount.Balance > 0) bankAccount.State = new PositiveBalance();
        }

        public void Withdraw(BankAccount bankAccount, double amount)
        {
            throw new Exception("Contas negativas não podem realizar saques.");
        }
    }
}
