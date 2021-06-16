using System;

namespace DesignPatterns
{
    public class SendEmail : IActionsAfterGeneratingInvoice
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine("Simulando o envio da nota por e-mail.");
        }
    }
}
