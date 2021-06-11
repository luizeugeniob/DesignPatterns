using System;

namespace DesignPatterns
{
    public class OnApproval : IBudgetState
    {
        protected bool DiscountApplied { get; set; }

        public void ApplyExtraDiscount(Budget budget)
        {
            if (DiscountApplied)
            {
                throw new Exception("O desconto já foi aplicado.");
            }

            budget.Amount -= budget.Amount * 0.05;
            DiscountApplied = true;
        }

        public void Approves(Budget budget)
        {
            budget.State = new Approved();
        }

        public void Disapprove(Budget budget)
        {
            budget.State = new Disapproved();
        }

        public void Finalize(Budget budget)
        {
            throw new Exception("Orçamento em aprovação não pode ser finalizado.");
        }
    }
}
