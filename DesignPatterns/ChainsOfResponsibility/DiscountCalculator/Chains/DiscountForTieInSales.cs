namespace DesignPatterns
{
    public class DiscountForTieInSales : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discounts(Budget budget)
        {
            if (budget.HasItemWithName("LAPIS") &&
                budget.HasItemWithName("CANETA"))
            {
                return budget.Amount * 0.05;
            }

            return Next.Discounts(budget);
        }
    }
}
