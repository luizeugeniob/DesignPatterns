namespace DesignPatterns
{
    public class ClientMessage : IMessage
    {
        private readonly string name;

        public ISender Sender { get; set; }

        public ClientMessage(string name)
        {
            this.name = name;
        }

        public void Send()
        {
            Sender.Send(this);
        }

        public string Format()
        {
            return string.Format("Enviando a mensagem para o cliente {0}.", name);
        }
    }
}
