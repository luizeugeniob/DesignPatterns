using System;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var invoiceBuilder = new InvoiceBuilder();

            invoiceBuilder
                .ForCompany("Empresa 123")
                .WithCnpj("00.000.000/0001-00")
                .WithItem(new InvoiceItem("Item 1", 150.50))
                .WithItem(new InvoiceItem("Item 2", 230.90))
                .OnDate(new DateTime(1994, 6, 5))
                .WithObservation("Entrega urgente.");

            invoiceBuilder.AddAction(new Multiplier(5));

            var invoice = invoiceBuilder.Build();

            Console.WriteLine(invoice.GrossAmount);
            Console.WriteLine(invoice.Tax);
            Console.WriteLine(invoice.IssueDate);

            Console.ReadLine();
        }
    }
}
