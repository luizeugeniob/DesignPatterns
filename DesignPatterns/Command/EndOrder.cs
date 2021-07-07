using System;

namespace DesignPatterns
{
    public class EndOrder : ICommand
    {
        private readonly Order order;

        public EndOrder(Order order)
        {
            this.order = order;
        }

        public void Execute()
        {
            Console.WriteLine($"Finalizando o pedido do cliente {order.Customer}.");
            order.Ends();
        }
    }
}
