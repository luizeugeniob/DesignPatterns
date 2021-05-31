using System.Collections.Generic;

namespace DesignPatterns
{

    public class DiscountCalculator
    {
        public double Calculate(Budget budget)
        {
            IDiscount discount1 = new DiscountForFiveItems();
            IDiscount discount2 = new DiscountForMoreThanFiveHundredReais();
            IDiscount discount3 = new NoDiscount();

            discount1.Next = discount2;
            discount2.Next = discount3;

            return discount1.Discounts(budget);
        }
    }

}
