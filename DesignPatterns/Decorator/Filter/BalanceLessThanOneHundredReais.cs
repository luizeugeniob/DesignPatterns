using System.Collections.Generic;

namespace DesignPatterns
{
    public class BalanceLessThanOneHundredReais : Filter
    {
        public BalanceLessThanOneHundredReais() { }
        public BalanceLessThanOneHundredReais(Filter anotherFilter) : base(anotherFilter) { }

        public override IList<BankAccount> Filtrate(IList<BankAccount> bankAccounts)
        {
            foreach (var bankAccount in bankAccounts)
            {
                if (bankAccount.Balance < 100)
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
