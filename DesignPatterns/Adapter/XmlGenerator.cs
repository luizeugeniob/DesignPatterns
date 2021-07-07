using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns
{
    public class XmlGenerator
    {
        public string GenerateXml(object o)
        {
            var serializer = new XmlSerializer(o.GetType());
            var writer = new StringWriter();
            serializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
