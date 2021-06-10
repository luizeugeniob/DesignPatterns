namespace DesignPatterns
{
    public class Ikcv : ConditionalTaxTemplate
    {
        public Ikcv(Tax anotherTax) : base(anotherTax) { }
        public Ikcv() { }

        protected override bool MustUseMaximumTax(Budget budget)
        {
            return budget.Amount > 500 && budget.HasItemWithAmountGreaterThanOneHundred();
        }

        protected override double MaximumTax(Budget budget)
        {
            return budget.Amount * 0.1;
        }

        protected override double MinimumTax(Budget budget)
        {
            return budget.Amount * 0.06;
        }
    }
}
