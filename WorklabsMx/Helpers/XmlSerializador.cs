using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WorklabsMx.Helpers
{
    public class XmlSerializador
    {

        public string Serializar(Type type, object data){
            XmlSerializer xml = new XmlSerializer(type);
            string output = "";
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xml.Serialize(writer, data);
                    output = sww.ToString();
                }
            }
            Console.WriteLine(output);
            return output;
        }
    }
}
