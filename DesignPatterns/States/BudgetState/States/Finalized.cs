using System;

namespace DesignPatterns
{
    public class Finalized : IBudgetState
    {
        public void ApplyExtraDiscount(Budget budget)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto");
        }

        public void Approves(Budget budget)
        {
            throw new Exception("Orçamento já está finalizado.");
        }

        public void Disapprove(Budget budget)
        {
            throw new Exception("Orçamento já está finalizado.");
        }

        public void Finalize(Budget budget)
        {
            throw new Exception("Orçamento já está finalizado.");
        }
    }
}
