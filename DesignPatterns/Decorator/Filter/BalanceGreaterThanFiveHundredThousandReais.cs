using System.Collections.Generic;

namespace DesignPatterns
{
    public class BalanceGreaterThanFiveHundredThousandReais : Filter
    {
        public BalanceGreaterThanFiveHundredThousandReais() { }
        public BalanceGreaterThanFiveHundredThousandReais(Filter anotherFilter) : base(anotherFilter) { }

        public override IList<BankAccount> Filtrate(IList<BankAccount> bankAccounts)
        {
            foreach (var bankAccount in bankAccounts)
            {
                if (bankAccount.Balance > 500000)
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
