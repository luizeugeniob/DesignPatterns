using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class SimpleReport : ReportTemplate
    {
        protected override void PrintHeader()
        {
            Console.WriteLine("Banco Template");
        }

        protected override void PrintBody(List<BankAccount> bankAccounts)
        {
            foreach (var account in bankAccounts)
            {
                Console.WriteLine($"{account.Holder} - {account.Balance}");
            }
        }

        protected override void PrintFooter()
        {
            Console.WriteLine("(99) 9999-9999");
        }
    }
}
