namespace DesignPatterns
{
    public class Conservative : IInvestment
    {
        public double Apply(BankAccount bankAccount)
        {
            return bankAccount.Balance * 0.008;
        }
    }
}
