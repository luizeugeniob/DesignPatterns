using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class InvoiceBuilder
    {
        public string CompanyName { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime IssueDate { get; private set; }
        public string Observation { get; private set; }

        private double grossAmount;
        private double tax;
        private readonly IList<InvoiceItem> items = new List<InvoiceItem>();

        public InvoiceBuilder()
        {
            IssueDate = DateTime.Now;
        }

        private readonly IList<IActionsAfterGeneratingInvoice> actionsAfterGeneratingInvoice =
            new List<IActionsAfterGeneratingInvoice>();

        public Invoice Build()
        {
            var invoice = new Invoice(
                CompanyName,
                Cnpj,
                IssueDate,
                grossAmount,
                tax,
                items,
                Observation);

            foreach (var action in actionsAfterGeneratingInvoice)
            {
                action.Execute(invoice);
            }

            return invoice;
        }

        public void AddAction(IActionsAfterGeneratingInvoice newAction)
        {
            actionsAfterGeneratingInvoice.Add(newAction);
        }

        public InvoiceBuilder ForCompany(string companyName)
        {
            CompanyName = companyName;
            return this;
        }

        public InvoiceBuilder WithCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public InvoiceBuilder WithObservation(string observation)
        {
            Observation = observation;
            return this;
        }

        public InvoiceBuilder OnDate(DateTime issueDate)
        {
            IssueDate = issueDate;
            return this;
        }

        public InvoiceBuilder WithItem(InvoiceItem invoiceItem)
        {
            items.Add(invoiceItem);
            grossAmount += invoiceItem.Amount;
            tax += invoiceItem.Amount * 0.05;
            return this;
        }
    }
}
