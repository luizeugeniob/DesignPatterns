namespace DesignPatterns
{
    public class DiscountForMoreThanFiveHundredReais : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discounts(Budget budget)
        {
            if (budget.Amount >= 500)
            {
                return budget.Amount * 0.07;
            }

            return Next.Discounts(budget);
        }
    }
}
