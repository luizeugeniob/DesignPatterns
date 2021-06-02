using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var account1 = new BankAccount("Fulano", 200, "123-4", "98765432-1");
            account1.DepositsValue(1000);

            var account2 = new BankAccount("Ciclano", 200, "123-4", "87654321-9");
            account2.DepositsValue(1500);

            var account3 = new BankAccount("Beltrano", 200, "123-4", "76543219-8");
            account3.DepositsValue(750);

            var bankAccounts = new List<BankAccount> { account1, account2, account3 };

            var report = new SimpleReport();

            report.PrintReport(bankAccounts);

            Console.ReadLine();
        }
    }
}
