namespace DesignPatterns
{
    public class DiscountCalculator
    {
        public double Calculate(Budget budget)
        {
            IDiscount discount1 = new DiscountForFiveItems();
            IDiscount discount2 = new DiscountForMoreThanFiveHundredReais();
            IDiscount discount3 = new DiscountForTieInSales();

            discount1.Next = discount2;
            discount2.Next = discount3;
            discount3.Next = new NoDiscount();

            return discount1.Discounts(budget);
        }
    }
}
