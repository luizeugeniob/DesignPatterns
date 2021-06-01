using System;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var request = new Request(Format.PERCENT);

            var bankAccount = new BankAccount("Luiz", 200, "123-4", "98765432-1");

            var requestChain = new RequestChain();

            requestChain.PrintBankAccount(request, bankAccount);

            Console.ReadLine();
        }
    }
}
