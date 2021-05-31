namespace DesignPatterns
{
    public class Item
    {
        public string Name { get; private set; }
        public double Amount { get; private set; }

        public Item(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
