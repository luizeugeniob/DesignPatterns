using System;

namespace DesignPatterns
{
    public class InvoiceRepository : IActionsAfterGeneratingInvoice
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine("Simulando a persistência da nota no banco de dados.");
        }
    }
}
