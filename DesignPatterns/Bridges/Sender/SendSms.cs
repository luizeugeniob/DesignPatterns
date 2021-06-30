using System;

namespace DesignPatterns.Bridges
{
    public class SendSms : ISender
    {
        public void Send(IMessage message)
        {
            Console.WriteLine("Enviando a mensagem por SMS.");
            Console.WriteLine(message.Format());
        }
    }
}
