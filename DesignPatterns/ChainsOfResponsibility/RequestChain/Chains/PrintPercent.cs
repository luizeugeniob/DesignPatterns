using System;

namespace DesignPatterns
{
    public class PrintPercent : IPrint
    {
        public IPrint Next { get; set; }

        public void Print(Request request, BankAccount bankAccount)
        {
            if (request.Format == Format.PERCENT)
            {
                Console.WriteLine($"{bankAccount.Holder}%{bankAccount.BankCode}%{bankAccount.AgencyNumber}%{bankAccount.AccountNumber}");
            }
            else
            {
                Next.Print(request, bankAccount);
            }
        }
    }
}
