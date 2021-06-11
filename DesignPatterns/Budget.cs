using System.Collections.Generic;

namespace DesignPatterns
{
    public class Budget
    {
        public double Amount { get; set; }
        public List<Item> Items { get; private set; }
        public IBudgetState State { get; set; }

        public Budget(double amount)
        {
            Amount = amount;
            Items = new List<Item>();
            State = new OnApproval();
        }

        public void ApplyExtraDiscount()
        {
            State.ApplyExtraDiscount(this);
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void Approves()
        {
            State.Approves(this);
        }

        public void Disapprove()
        {
            State.Disapprove(this);
        }

        public void Finalize()
        {
            State.Finalize(this);
        }
    }
}
