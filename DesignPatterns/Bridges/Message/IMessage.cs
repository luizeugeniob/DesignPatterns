namespace DesignPatterns
{
    public interface IMessage
    {
        ISender Sender { get; set; }

        void Send();
        string Format();
    }
}
