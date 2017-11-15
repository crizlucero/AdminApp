using System;
using System.Xml.Serialization;

namespace WorklabsMx.Models.Pagos
{
    public class data
    {
        public data()
        {
            id = 1;
            display = true;
        }
        [XmlAttribute]
        public int id { get;  }
        [XmlAttribute]
        public bool display { get; }

        [XmlElement]
        public string label { get; set; }
        [XmlElement]
        public string value { get; set; }
    }
}
