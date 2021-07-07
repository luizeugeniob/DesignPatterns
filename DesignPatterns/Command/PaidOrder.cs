using System;

namespace DesignPatterns
{
    public class PaidOrder : ICommand
    {
        private readonly Order order;

        public PaidOrder(Order order)
        {
            this.order = order;
        }

        public void Execute()
        {
            Console.WriteLine($"Pagando o pedido do cliente {order.Customer}.");
            order.Paid();
        }
    }
}
