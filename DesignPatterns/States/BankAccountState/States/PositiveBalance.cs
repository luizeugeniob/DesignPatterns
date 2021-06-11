namespace DesignPatterns
{
    public class PositiveBalance : IBankAccountState
    {
        public void Deposit(BankAccount bankAccount, double amount)
        {
            bankAccount.Balance += amount * 0.98;
        }

        public void Withdraw(BankAccount bankAccount, double amount)
        {
            bankAccount.Balance -= amount;

            if (bankAccount.Balance < 0) bankAccount.State = new NegativeBalance();
        }
    }
}
