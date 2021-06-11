using System;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var bankAccount = new BankAccount(
                "Fulano",
                200,
                "123-4",
                "98765432-1",
                DateTime.Now);

            bankAccount.Deposit(500);
            Console.WriteLine(bankAccount.Balance);

            bankAccount.Withdraw(550);
            Console.WriteLine(bankAccount.Balance);

            bankAccount.Deposit(60);
            Console.WriteLine(bankAccount.Balance);

            Console.ReadLine();
        }
    }
}
