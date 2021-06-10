namespace DesignPatterns
{
    public abstract class ConditionalTaxTemplate : Tax
    {
        public override double Calculate(Budget budget)
        {
            if (MustUseMaximumTax(budget))
            {
                return MaximumTax(budget);
            }

            return MinimumTax(budget);
        }

        protected abstract bool MustUseMaximumTax(Budget budget);
        protected abstract double MaximumTax(Budget budget);
        protected abstract double MinimumTax(Budget budget);
    }
}
