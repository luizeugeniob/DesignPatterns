namespace DesignPatterns
{
    public class Iss : Tax
    {
        public Iss(Tax anotherTax) : base(anotherTax) { }
        public Iss() { }

        public override double Calculate(Budget budget)
        {
            return budget.Amount * 0.06 + CalculateAnotherTax(budget);
        }
    }
}
