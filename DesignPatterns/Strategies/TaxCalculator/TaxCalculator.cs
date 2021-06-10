using System;

namespace DesignPatterns
{
    public class TaxCalculator
    {
        public void Calculate(Budget budget, Tax tax)
        {
            var feeAmount = tax.Calculate(budget);
            Console.WriteLine(feeAmount);
        }
    }
}
