namespace DesignPatterns
{
    public class DiscountForFiveItems : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discounts(Budget budget)
        {
            if (budget.Items.Count > 5)
            {
                return budget.Amount * 0.1;
            }

            return Next.Discounts(budget);
        }
    }
}
