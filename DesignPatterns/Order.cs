using System;

namespace DesignPatterns
{
    public class Order
    {
        public string Customer { get; private set; }
        public double Amount { get; private set; }
        public DateTime EndDate { get; private set; }
        public OrderStatus Status { get; private set; }

        public Order(string customer, double amount)
        {
            Customer = customer;
            Amount = amount;
            Status = OrderStatus.New;
        }

        public void Paid()
        {
            Status = OrderStatus.Paid;
        }

        public void Ends()
        {
            Status = OrderStatus.Delivered;
            EndDate = DateTime.Now;
        }
    }

    public enum OrderStatus
    {
        New,
        Processed,
        Paid,
        SeparatedItems,
        Delivered
    }
}
