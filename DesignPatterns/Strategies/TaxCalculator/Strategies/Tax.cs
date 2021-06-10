namespace DesignPatterns
{
    public abstract class Tax
    {
        public Tax AnotherTax { get; set; }

        protected Tax(Tax anotherTax)
        {
            AnotherTax = anotherTax;
        }

        protected Tax()
        {
            AnotherTax = null;
        }

        public abstract double Calculate(Budget budget);

        protected double CalculateAnotherTax(Budget budget)
        {
            if (AnotherTax == null) return 0;

            return AnotherTax.Calculate(budget);
        }
    }
}
