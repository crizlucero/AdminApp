using WorklabsMx.Enum;
using Foundation;

namespace WorklabsMx.iOS.Models
{
    public class OrdenVentaController : NSObject
    {
        public string empresa_miembro_id { get; set; }
        public string moneda_id { get; set; }
        public string impuesto_id { get; set; }
        public string promocion_id { get; set; }
        public string descuento_id { get; set; }
        public string folio { get; set; }
        public int suma { get; set; }
        public string porcentajeDecuento { get; set; }
        public string descuento { get; set; }
        public string subTotal { get; set; }
        public string impuesto { get; set; }
        public string total { get; set; }
        public string pagado { get; set; }
        public string facturado { get; set; }
        public string estatus { get; set; }
    }
}
