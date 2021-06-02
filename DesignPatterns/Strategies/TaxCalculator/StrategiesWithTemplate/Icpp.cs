namespace DesignPatterns
{
    public class Icpp : ConditionalTaxTemplate
    {
        public override bool MustUseMaximumTax(Budget budget)
        {
            return budget.Amount >= 500;
        }

        public override double MaximumTax(Budget budget)
        {
            return budget.Amount * 0.07;
        }

        public override double MinimumTax(Budget budget)
        {
            return budget.Amount * 0.05;
        }
    }
}
