using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var historic = new ContractHistoric();

            var contract = new Contract(DateTime.Now, "Luiz", ContractType.New);
            historic.Add(contract.SaveState());

            contract.Next();
            historic.Add(contract.SaveState());

            contract.Next();
            historic.Add(contract.SaveState());

            Console.WriteLine(historic.Get(1).Contract.Type);
        }
    }
}
