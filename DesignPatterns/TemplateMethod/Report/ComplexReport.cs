using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class ComplexReport : ReportTemplate
    {
        protected override void PrintHeader()
        {
            Console.WriteLine("Banco Template");
            Console.WriteLine("Rua dos bobos, nº 0");
            Console.WriteLine("(99) 9999-9999");
        }

        protected override void PrintBody(List<BankAccount> bankAccounts)
        {
            foreach (var account in bankAccounts)
            {
                Console.WriteLine($"{account.Holder} - {account.AccountNumber} - {account.AgencyNumber} - {account.Balance}");
            }
        }

        protected override void PrintFooter()
        {
            Console.WriteLine("contato@bancotemplate.com.br");
            Console.WriteLine(DateTime.Now);
        }
    }
}
