namespace DesignPatterns
{
    public class Ima : Tax
    {
        public Ima(Tax anotherTax) : base(anotherTax) { }
        public Ima() { }

        public override double Calculate(Budget budget)
        {
            return (budget.Amount * 0.2) + CalculateAnotherTax(budget);
        }
    }
}
