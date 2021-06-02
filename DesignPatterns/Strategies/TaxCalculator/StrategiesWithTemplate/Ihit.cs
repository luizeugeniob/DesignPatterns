namespace DesignPatterns
{
    public class Ihit : ConditionalTaxTemplate
    {
        protected override bool MustUseMaximumTax(Budget budget)
        {
            return HasTwoItemsWithSameName(budget);
        }

        protected override double MaximumTax(Budget budget)
        {
            return budget.Amount * 0.13 + 100;
        }

        protected override double MinimumTax(Budget budget)
        {
            return budget.Amount * (0.01 * budget.Items.Count);
        }

        private bool HasTwoItemsWithSameName(Budget budget)
        {
            foreach (var item in budget.Items)
            {
                if (budget.QuantityOfItemsWithName(item.Name) == 2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
