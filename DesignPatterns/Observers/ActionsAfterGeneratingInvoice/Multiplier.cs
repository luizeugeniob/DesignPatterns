using System;

namespace DesignPatterns
{
    public class Multiplier : IActionsAfterGeneratingInvoice
    {
        public double Factor { get; set; }

        public Multiplier(double factor)
        {
            Factor = factor;
        }

        public void Execute(Invoice invoice)
        {
            Console.WriteLine(invoice.GrossAmount * Factor);
        }
    }
}
