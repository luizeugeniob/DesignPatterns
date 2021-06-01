using System;

namespace DesignPatterns
{
    public class NoPrint : IPrint
    {
        public IPrint Next { get; set; }

        public void Print(Request request, BankAccount bankAccount)
        {
            Console.WriteLine("Formato inválido");
        }
    }
}
