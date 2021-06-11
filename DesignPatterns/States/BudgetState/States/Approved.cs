using System;

namespace DesignPatterns
{
    public class Approved : IBudgetState
    {
        protected bool DiscountApplied { get; set; }

        public void ApplyExtraDiscount(Budget budget)
        {
            if (DiscountApplied)
            {
                throw new Exception("O desconto já foi aplicado.");
            }

            budget.Amount -= budget.Amount * 0.02;
            DiscountApplied = true;
        }

        public void Approves(Budget budget)
        {
            throw new Exception("Orçamento já está aprovado.");
        }

        public void Disapprove(Budget budget)
        {
            throw new Exception("Orçamento aprovado não pode ser desaprovado.");
        }

        public void Finalize(Budget budget)
        {
            budget.State = new Finalized();
        }
    }
}
