namespace DesignPatterns
{
    public class InvoiceItem
    {
        public string Name { get; set; }
        public double Amount { get; set; }

        public InvoiceItem(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}