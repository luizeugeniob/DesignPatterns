using System.Collections.Generic;

namespace DesignPatterns
{
    public class Budget
    {
        public double Amount { get; private set; }
        public List<Item> Items { get; private set; }

        public Budget(double amount)
        {
            Amount = amount;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
