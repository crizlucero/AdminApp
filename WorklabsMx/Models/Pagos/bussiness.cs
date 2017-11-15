using System;
using System.Xml.Serialization;

namespace WorklabsMx.Models.Pagos
{
    public class bussiness
    {
        [XmlElement]
        public string id_company { get; set; }
        [XmlElement]
        public string id_branch { get; set; }
        [XmlElement]
        public string user { get; set; }
        [XmlElement]
        public string pwd { get; set; }

    }
}
