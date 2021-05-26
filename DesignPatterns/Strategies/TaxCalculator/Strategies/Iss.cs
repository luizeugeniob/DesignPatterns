namespace DesignPatterns
{
    public class Iss : ITax
    {
        public double Calculate(Budget budget)
        {
            return budget.Amount * 0.06;
        }
    }
}
