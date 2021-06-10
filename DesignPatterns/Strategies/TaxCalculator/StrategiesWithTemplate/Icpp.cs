namespace DesignPatterns
{
    public class Icpp : ConditionalTaxTemplate
    {
        public Icpp(Tax anotherTax) : base(anotherTax) { }
        public Icpp() { }

        protected override bool MustUseMaximumTax(Budget budget)
        {
            return budget.Amount >= 500;
        }

        protected override double MaximumTax(Budget budget)
        {
            return budget.Amount * 0.07;
        }

        protected override double MinimumTax(Budget budget)
        {
            return budget.Amount * 0.05;
        }
    }
}
