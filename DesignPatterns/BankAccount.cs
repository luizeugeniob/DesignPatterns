namespace DesignPatterns
{
    public class BankAccount
    {
        public string Holder { get; set; }
        public int BankCode { get; private set; }
        public string AgencyNumber { get; private set; }
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(
            string holder,
            int bankCode,
            string agencyNumber,
            string accountNumber)
        {
            Holder = holder;
            BankCode = bankCode;
            AgencyNumber = agencyNumber;
            AccountNumber = accountNumber;
        }

        public void DepositsValue(double amount)
        {
            Balance += amount;
        }
    }
}
