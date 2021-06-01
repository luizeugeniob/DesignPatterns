using System;

namespace DesignPatterns
{
    public class PrintXml : IPrint
    {
        public IPrint Next { get; set; }

        public void Print(Request request, BankAccount bankAccount)
        {
            if (request.Format == Format.XML)
            {
                Console.WriteLine(
                    "<BankAccount>" +
                        $"<Holder>{bankAccount.Holder}</Holder>" +
                        $"<BankCode>{bankAccount.BankCode}</BankCode>" +
                        $"<AgencyNumber>{bankAccount.AgencyNumber}</AgencyNumber>" +
                        $"<AccountNumber>{bankAccount.AccountNumber}</AccountNumber>" +
                    "</BankAccount>");
            }
            else
            {
                Next.Print(request, bankAccount);
            }
        }
    }
}
