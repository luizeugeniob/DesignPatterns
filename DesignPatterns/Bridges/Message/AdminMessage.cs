namespace DesignPatterns
{
    public class AdminMessage : IMessage
    {
        private readonly string name;

        public ISender Sender { get; set; }

        public AdminMessage(string name)
        {
            this.name = name;
        }

        public void Send()
        {
            Sender.Send(this);
        }

        public string Format()
        {
            return string.Format("Enviando a mensagem para o administrador {0}.", name);
        }
    }
}
