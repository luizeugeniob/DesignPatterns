namespace DesignPatterns
{
    public abstract class ConditionalTaxTemplate : Tax
    {
        protected ConditionalTaxTemplate(Tax anotherTax) : base(anotherTax) { }
        protected ConditionalTaxTemplate() { }

        public override double Calculate(Budget budget)
        {
            if (MustUseMaximumTax(budget))
            {
                return MaximumTax(budget) + CalculateAnotherTax(budget);
            }

            return MinimumTax(budget) + CalculateAnotherTax(budget);
        }

        protected abstract bool MustUseMaximumTax(Budget budget);
        protected abstract double MaximumTax(Budget budget);
        protected abstract double MinimumTax(Budget budget);
    }
}
