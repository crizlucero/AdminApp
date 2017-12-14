using Foundation;

namespace WorklabsMx.iOS.Models
{
    public class OrdenVentaDetalle: NSObject
    {
        public string detalle_id { get; set; }
        public string encabezado_id { get; set; }
        public string membresia_id { get; set; }
        public string inscripcion_membresia_id { get; set; }
        public string precio_membresia_id { get; set; }
        public string producto_id { get; set; }
        public string precio_producto_id { get; set; }
        public string detalle_descripcion { get; set; }
        public string detalle_cantidad { get; set; }
        public string importe_precio { get; set; }
        public string importe_prorrateo { get; set; }
        public string importe_descuento { get; set; }
        public string importe_subtotal { get; set; }
        public string importe_impuesto { get; set; }
        public string importe_total { get; set; }
        public string status { get; set; }
    }
}
