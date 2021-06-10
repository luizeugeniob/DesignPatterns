namespace DesignPatterns
{
    public class Icms : Tax
    {
        public Icms(Tax anotherTax) : base(anotherTax) { }
        public Icms() { }

        public override double Calculate(Budget budget)
        {
            return (budget.Amount * 0.1) + CalculateAnotherTax(budget);
        }
    }
}
