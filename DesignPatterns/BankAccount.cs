using System;

namespace DesignPatterns
{
    public class BankAccount
    {
        public string Holder { get; set; }
        public int BankCode { get; private set; }
        public string AgencyNumber { get; private set; }
        public string AccountNumber { get; private set; }
        public double Balance { get; set; }
        public DateTime OpeningDate { get; private set; }
        public IBankAccountState State { get; set; }

        public BankAccount(
            string holder,
            int bankCode,
            string agencyNumber,
            string accountNumber,
            DateTime openingDate)
        {
            Holder = holder;
            BankCode = bankCode;
            AgencyNumber = agencyNumber;
            AccountNumber = accountNumber;
            OpeningDate = openingDate;
            State = new PositiveBalance();
        }

        public void Deposit(double amount)
        {
            State.Deposit(this, amount);
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(this, amount);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BankAccount bankAccount)) return false;

            return AccountNumber == bankAccount.AccountNumber
                && BankCode == bankAccount.BankCode
                && AgencyNumber == bankAccount.AgencyNumber;
        }

        public override int GetHashCode()
        {
            return AccountNumber.GetHashCode()
                + BankCode.GetHashCode()
                + AgencyNumber.GetHashCode();
        }
    }
}
