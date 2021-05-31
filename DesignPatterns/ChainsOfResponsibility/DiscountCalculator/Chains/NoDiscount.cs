namespace DesignPatterns
{
    public class NoDiscount : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discounts(Budget budget)
        {
            return 0;
        }
    }
}
