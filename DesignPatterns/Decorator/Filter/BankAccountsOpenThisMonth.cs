using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class BankAccountsOpenThisMonth : Filter
    {
        public BankAccountsOpenThisMonth() { }
        public BankAccountsOpenThisMonth(Filter anotherFilter) : base(anotherFilter) { }

        public override IList<BankAccount> Filtrate(IList<BankAccount> bankAccounts)
        {
            foreach (var bankAccount in bankAccounts)
            {
                if (bankAccount.OpeningDate.Month == DateTime.Now.Month &&
                    bankAccount.OpeningDate.Year == DateTime.Now.Year)
                {
                    AddFilteredAccount(bankAccount);
                }
            }

            foreach (var bankAccount in FiltrateAnotherFilter(bankAccounts))
            {
                AddFilteredAccount(bankAccount);
            }

            return FilteredBankAccounts;
        }
    }
}
