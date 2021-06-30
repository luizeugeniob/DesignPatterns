using System;

namespace DesignPatterns.Bridges
{
    public class SendEmail : ISender
    {
        public void Send(IMessage message)
        {
            Console.WriteLine("Enviando a mensagem por e-mail.");
            Console.WriteLine(message.Format());
        }
    }
}
