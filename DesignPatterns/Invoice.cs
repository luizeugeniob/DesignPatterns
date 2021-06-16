using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Invoice
    {
        public string CompanyName { get; set; }
        public string Cnpj { get; set; }
        public DateTime IssueDate { get; set; }
        public double GrossAmount { get; set; }
        public double Tax { get; set; }
        public IList<InvoiceItem> Items { get; set; }
        public string Observation { get; set; }

        public Invoice(
            string companyName,
            string cnpj,
            DateTime issueDate,
            double grossAmount,
            double tax,
            IList<InvoiceItem> items,
            string observation)
        {
            CompanyName = companyName;
            Cnpj = cnpj;
            IssueDate = issueDate;
            GrossAmount = grossAmount;
            Tax = tax;
            Items = items;
            Observation = observation;
        }
    }
}
