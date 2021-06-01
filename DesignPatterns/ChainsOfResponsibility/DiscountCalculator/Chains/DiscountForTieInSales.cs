using System.Linq;

namespace DesignPatterns
{
    public class DiscountForTieInSales : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discounts(Budget budget)
        {
            if (ItemExistsInBudget("LAPIS", budget) &&
                ItemExistsInBudget("CANETA", budget))
            {
                return budget.Amount * 0.05;
            }

            return Next.Discounts(budget);
        }

        private bool ItemExistsInBudget(string itemName, Budget budget) 
            => budget.Items.Any(x => x.Name.Equals(itemName));
    }
}
