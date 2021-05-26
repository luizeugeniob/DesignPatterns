namespace DesignPatterns
{
    public class Icms : ITax
    {
        public double Calculate(Budget budget)
        {
            return budget.Amount * 0.1;
        }
    }
}
