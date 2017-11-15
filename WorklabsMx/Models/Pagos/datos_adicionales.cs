using System;
using System.Xml.Serialization;

namespace WorklabsMx.Models.Pagos
{
    public class datos_adicionales
    {
        [XmlElement]
        public data data { get; set; }
    }
}
