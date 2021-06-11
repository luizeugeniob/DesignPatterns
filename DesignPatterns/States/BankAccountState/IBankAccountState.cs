namespace DesignPatterns
{
    public interface IBankAccountState
    {
        void Withdraw(BankAccount bankAccount, double amount);
        void Deposit(BankAccount bankAccount, double amount);
    }
}
