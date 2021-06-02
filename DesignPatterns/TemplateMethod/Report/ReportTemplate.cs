using System.Collections.Generic;

namespace DesignPatterns
{
    public abstract class ReportTemplate
    {
        public void PrintReport(List<BankAccount> bankAccounts)
        {
            PrintHeader();
            PrintBody(bankAccounts);
            PrintFooter();
        }

        protected abstract void PrintHeader();
        protected abstract void PrintBody(List<BankAccount> bankAccounts);
        protected abstract void PrintFooter();
    }
}
