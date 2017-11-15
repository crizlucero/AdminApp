using System;
using System.Xml.Serialization;

namespace WorklabsMx.Models.Pagos
{
    public class url
    {
        public url()
        {
            canal = "W";
            omitir_notif_default = 1;
            st_correo = 1;
        }
        [XmlElement]
        public string reference { get; set; }
        [XmlElement]
        public string amount { get; set; }
        [XmlElement]
        public string moneda { get; set; }
        [XmlElement]
        public string canal { get; }
        [XmlElement]
        public int omitir_notif_default { get; }
        [XmlElement]
        public int st_correo { get; }
        [XmlElement]
        public string mail_cliente { get; set; }
        [XmlElement]
        public datos_adicionales datos_adicionales { get; set; }
    }
}
