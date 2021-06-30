namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var mailMessage = new AdminMessage("Luiz");

            mailMessage.Sender = new Bridges.SendSms(); // Fazendo uma ponte entre a Message e o Sender
            mailMessage.Send();

            mailMessage.Sender = new Bridges.SendEmail();
            mailMessage.Send();
        }
    }
}
