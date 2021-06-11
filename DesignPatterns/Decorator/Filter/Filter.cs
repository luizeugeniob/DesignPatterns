using System.Collections.Generic;

namespace DesignPatterns
{
    public abstract class Filter
    {
        public Filter AnotherFilter { get; set; }

        protected List<BankAccount> FilteredBankAccounts = new List<BankAccount>();

        protected Filter()
        {
            AnotherFilter = null;
        }

        protected Filter(Filter anotherFilter)
        {
            AnotherFilter = anotherFilter;
        }

        public abstract IList<BankAccount> Filtrate(IList<BankAccount> bankAccounts);

        protected IList<BankAccount> FiltrateAnotherFilter(IList<BankAccount> bankAccounts)
        {
            if (AnotherFilter == null) return new List<BankAccount>();

            return AnotherFilter.Filtrate(bankAccounts);
        }

        protected void AddFilteredAccount(BankAccount bankAccount)
        {
            if (!FilteredBankAccounts.Contains(bankAccount))
            {
                FilteredBankAccounts.Add(bankAccount);
            }
        }
    }
}
