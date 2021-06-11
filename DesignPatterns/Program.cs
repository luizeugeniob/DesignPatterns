using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var account1 = new BankAccount(
                "Fulano",
                200,
                "123-4",
                "98765432-1",
                DateTime.Now);
            account1.DepositsValue(90);

            var account2 = new BankAccount(
                "Ciclano",
                200,
                "123-4",
                "87654321-9",
                new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day));
            account2.DepositsValue(1500);

            var account3 = new BankAccount(
                "Beltrano",
                200,
                "123-4",
                "76543219-8",
                new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day));
            account3.DepositsValue(500001);

            var account4 = new BankAccount(
                "Fulano Júnior",
                200,
                "123-4",
                "65432198-7",
                new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month - 1,
                    DateTime.Now.Day));
            account4.DepositsValue(25000);

            var bankAccounts = new List<BankAccount> { account1, account2, account3, account4 };

            var filters = new BalanceLessThanOneHundredReais(
                new BalanceGreaterThanFiveHundredThousandReais(
                    new BankAccountsOpenThisMonth()));

            var filteredBankAccounts = filters.Filtrate(bankAccounts);

            var report = new SimpleReport();

            report.PrintReport(filteredBankAccounts.ToList());

            Console.ReadLine();
        }
    }
}
