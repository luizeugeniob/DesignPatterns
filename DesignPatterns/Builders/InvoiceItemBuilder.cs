namespace DesignPatterns.Builders
{
    public class InvoiceItemBuilder
    {
        public string Name { get; private set; }
        public double Amount { get; private set; }

        public InvoiceItemBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public InvoiceItemBuilder WithAmount(double amount)
        {
            Amount = amount;
            return this;
        }

        public InvoiceItem Build()
        {
            return new InvoiceItem(Name, Amount);
        }
    }
}
