using System;
using System.Xml.Serialization;

namespace WorklabsMx.Models.Pagos
{
    public class P
    {
        [XmlElement]
        public bussiness bussiness { get; set; }
        [XmlElement]
        public url url { get; set; }
    }
}
