using SQLite;
using WorklabsMx.Enum;

namespace WorklabsMx.Models
{
    public class OrdenVentaDetalle
    {
        [PrimaryKey, AutoIncrement]
        public int Orden_Venta_Detalle_Id { get; set; }
        public int Orden_Venta_Encabezado_Id { get; set; }
        public string Membresia_Id { get; set; }
        public string Inscripcion_Membresia_Id { get; set; }
        public string Lista_Precio_Membresia_Id { get; set; }
        public string Producto_Id { get; set; }
        public string Lista_Precio_Producto_Id { get; set; }
        public string Orden_Venta_Detalle_Descripcion { get; set; }
        public int Orden_Venta_Detalle_Cantidad { get; set; }
        public decimal Orden_Venta_Detalle_Importe_Precio { get; set; }
        public decimal Orden_Venta_Detalle_Importe_Prorrateo { get; set; }
        public decimal Orden_Venta_Detalle_Importe_Suma { get; set; }
        public decimal Orden_Venta_Detalle_Importe_Descuento { get; set; }
        public decimal Orden_Venta_Detalle_Importe_Subtotal { get; set; }
        public decimal Orden_Venta_Detalle_Importe_Impuesto { get; set; }
        public decimal Orden_Venta_Detalle_Importe_Total { get; set; }
        public decimal Orden_Venta_Detalle_Estatus { get; set; }
        public decimal Orden_Venta_Detalle_Fecha_Alta { get; set; }
        public decimal Orden_Venta_Detalle_Fecha_Modificacion { get; set; }
        public decimal Orden_Venta_Detalle_Fecha_Baja { get; set; }
        public TiposServicios Tipos_Servicios { get; set; }


        public override string ToString() => string.Format("[Orden_Venta_Detalle_Id={0},Orden_Venta_Encabezado_Id={1}, Membresia_Id={2}, Inscripcion_Membresia_Id={3}, " +
                                 "Lista_Precio_Membresia_Id={4}, Producto_Id={5}, Lista_Precio_Producto_Id={6}, Orden_Venta_Detalle_Descripcion={7}, " +
                                 "Orden_Venta_Detalle_Cantidad={8}, Orden_Venta_Detalle_Importe_Precio={9}, Orden_Venta_Detalle_Importe_Prorrateo={10}, " +
                                 "Orden_Venta_Detalle_Importe_Suma={11}, Orden_Venta_Detalle_Importe_Descuento={12}, Orden_Venta_Detalle_Importe_Subtotal={13}, " +
                                 "Orden_Venta_Detalle_Importe_Impuesto={14}, Orden_Venta_Detalle_Importe_Total={15}, Orden_Venta_Detalle_Estatus={16}, " +
                                 "Orden_Venta_Detalle_Fecha_Alta={17}, Orden_Venta_Detalle_Fecha_Modificacion={18}, Orden_Venta_Detalle_Fecha_Baja={19}, Tipos_Servicios={20}]",
                                 Orden_Venta_Detalle_Id, Orden_Venta_Encabezado_Id, Membresia_Id, Inscripcion_Membresia_Id, Lista_Precio_Membresia_Id,
                                 Producto_Id, Lista_Precio_Producto_Id, Orden_Venta_Detalle_Descripcion, Orden_Venta_Detalle_Cantidad,
                                 Orden_Venta_Detalle_Importe_Precio, Orden_Venta_Detalle_Importe_Prorrateo, Orden_Venta_Detalle_Importe_Suma,
                                 Orden_Venta_Detalle_Importe_Descuento, Orden_Venta_Detalle_Importe_Subtotal, Orden_Venta_Detalle_Importe_Impuesto,
                                 Orden_Venta_Detalle_Importe_Total, Orden_Venta_Detalle_Estatus, Orden_Venta_Detalle_Fecha_Alta,
                                 Orden_Venta_Detalle_Fecha_Modificacion, Orden_Venta_Detalle_Fecha_Baja, Tipos_Servicios);
    }
}



