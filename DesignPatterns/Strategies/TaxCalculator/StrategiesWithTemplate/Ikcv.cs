namespace DesignPatterns
{
    public class Ikcv : ConditionalTaxTemplate
    {
        public override bool MustUseMaximumTax(Budget budget)
        {
            return budget.Amount > 500 && budget.HasItemWithAmountGreaterThanOneHundred();
        }

        public override double MaximumTax(Budget budget)
        {
            return budget.Amount * 0.1;
        }

        public override double MinimumTax(Budget budget)
        {
            return budget.Amount * 0.06;
        }
    }
}
