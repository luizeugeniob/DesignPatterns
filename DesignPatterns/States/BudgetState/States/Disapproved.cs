using System;

namespace DesignPatterns
{
    public class Disapproved : IBudgetState
    {
        public void ApplyExtraDiscount(Budget budget)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto");
        }

        public void Approves(Budget budget)
        {
            throw new Exception("Orçamento reprovado não pode ser aprovado.");
        }

        public void Disapprove(Budget budget)
        {
            throw new Exception("Orçamento já está desaprovado.");
        }

        public void Finalize(Budget budget)
        {
            budget.State = new Finalized();
        }
    }
}
