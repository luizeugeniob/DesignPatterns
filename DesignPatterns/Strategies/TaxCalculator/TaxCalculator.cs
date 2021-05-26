using System;

namespace DesignPatterns
{
    public class TaxCalculator
    {
        public void Calculate(Budget budget, ITax tax)
        {
            var feeAmount = tax.Calculate(budget);
            Console.WriteLine(feeAmount);
        }
    }
}
