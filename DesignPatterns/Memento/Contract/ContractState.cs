namespace DesignPatterns
{
    public class ContractState
    {
        public Contract Contract { get; set; }

        public ContractState(Contract contract)
        {
            Contract = contract;
        }
    }
}
