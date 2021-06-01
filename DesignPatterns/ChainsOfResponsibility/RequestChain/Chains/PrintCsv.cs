using System;

namespace DesignPatterns
{
    public class PrintCsv : IPrint
    {
        public IPrint Next { get; set; }

        public void Print(Request request, BankAccount bankAccount)
        {
            if (request.Format == Format.CSV)
            {
                Console.WriteLine($"{bankAccount.Holder};{bankAccount.BankCode};{bankAccount.AgencyNumber};{bankAccount.AccountNumber}");
            }
            else
            {
                Next.Print(request, bankAccount);
            }
        }
    }
}
