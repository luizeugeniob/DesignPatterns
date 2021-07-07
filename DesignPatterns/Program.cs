namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var queue = new WorkQueue();

            var order1 = new Order("Beltrano", 100);
            var order2 = new Order("Fulano", 200);

            queue.Add(new PaidOrder(order1));
            queue.Add(new PaidOrder(order2));

            queue.Add(new EndOrder(order1));

            queue.Proccess();
        }
    }
}
