namespace DesignPatterns
{
    public class Number : IExpression
    {
        private readonly int number;

        public Number(int number)
        {
            this.number = number;
        }

        public int Evaluate()
        {
            return number;
        }
    }
}
