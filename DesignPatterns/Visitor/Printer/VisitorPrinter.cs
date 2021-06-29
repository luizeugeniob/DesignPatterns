using System;

namespace DesignPatterns
{
    public class VisitorPrinter : IVisitorPrinter
    {
        public void PrintSum(Sum sum)
        {
            Console.Write("(");
            sum.Left.Print(this);
            Console.Write(" + ");
            sum.Right.Print(this);
            Console.Write(")");
        }

        public void PrintSubtraction(Subtraction subtraction)
        {
            Console.Write("(");
            subtraction.Left.Print(this);
            Console.Write(" - ");
            subtraction.Right.Print(this);
            Console.Write(")");
        }

        public void PrintNumber(Number number)
        {
            Console.Write(number.Value);
        }
    }
}
