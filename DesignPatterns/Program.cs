using System;
using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var customer = new Customer
            {
                Name = "Fulano",
                Address = "Rua dos bobos",
                BirthDate = DateTime.Now
            };

            var xml = new XmlGenerator().GenerateXml(customer);

            Console.WriteLine(xml);
        }
    }
}
