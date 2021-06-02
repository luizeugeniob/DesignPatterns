namespace DesignPatterns
{
    public abstract class ConditionalTaxTemplate : ITax
    {
        public double Calculate(Budget budget)
        {
            if (MustUseMaximumTax(budget))
            {
                return MaximumTax(budget);
            }

            return MinimumTax(budget);
        }

        public abstract bool MustUseMaximumTax(Budget budget);
        public abstract double MaximumTax(Budget budget);
        public abstract double MinimumTax(Budget budget);
    }
}
