using System;

namespace DesignPatterns
{
    public class Contract
    {
        public DateTime Date { get; private set; }
        public string Client { get; private set; }
        public ContractType Type { get; private set; }

        public Contract(
            DateTime date,
            string client,
            ContractType type)
        {
            Date = date;
            Client = client;
            Type = type;
        }

        public void Next()
        {
            switch (Type)
            {
                case ContractType.New:
                    Type = ContractType.InProgress;
                    break;

                case ContractType.InProgress:
                    Type = ContractType.Agreed;
                    break;

                case ContractType.Agreed:
                    Type = ContractType.Completed;
                    break;
            }
        }

        public ContractState SaveState()
        {
            return new ContractState(new Contract(Date, Client, Type));
        }

        public void Restore(ContractState contractState)
        {
            Date = contractState.Contract.Date;
            Client = contractState.Contract.Client;
            Type = contractState.Contract.Type;
        }
    }

    public enum ContractType
    {
        New = 0,
        InProgress = 1,
        Agreed = 2,
        Completed = 3
    }
}
