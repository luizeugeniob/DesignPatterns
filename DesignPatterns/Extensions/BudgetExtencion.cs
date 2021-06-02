using System.Linq;

namespace DesignPatterns
{
    public static class BudgetExtencion
    {
        public static bool HasItemWithName(this Budget budget, string itemName)
            => budget.Items.Any(x => x.Name.Equals(itemName));

        public static bool HasItemWithAmountGreaterThanOneHundred(this Budget budget)
            => budget.Items.Any(x => x.Amount > 100);
    }
}
