using System;

namespace DesignPatterns
{
    public class SendSms : IActionsAfterGeneratingInvoice
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine("Simulando o envio da nota por SMS.");
        }
    }
}
