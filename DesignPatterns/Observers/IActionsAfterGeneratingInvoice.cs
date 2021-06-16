namespace DesignPatterns
{
    public interface IActionsAfterGeneratingInvoice
    {
        void Execute(Invoice invoice);
    }
}
