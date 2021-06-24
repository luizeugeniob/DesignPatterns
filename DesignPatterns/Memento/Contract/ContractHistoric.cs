using System.Collections.Generic;

namespace DesignPatterns
{
    public class ContractHistoric
    {
        private readonly IList<ContractState> States = new List<ContractState>();

        public void Add(ContractState contractState)
        {
            States.Add(contractState);
        }

        public ContractState Get(int index)
        {
            return States[index];
        }
    }
}
