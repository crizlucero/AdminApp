using System;
namespace WorklabsMx.Models
{
    public class CarritoModel
    {
        public string Pedido_Id { get; set; }
        public string Miembro_Id { get; set; }
        public string Producto_Id { get; set; }
        public int Producto_Cantidad { get; set; }
        public string Membresia_Id { get; set; }
        public int Membresia_Cantidad { get; set; }
        public string Pedido_Estatus { get; set; }
        public string Precio_Base { get; set; }
        public string Dias_Prorrateo { get; set; }
        public string Pedido_Total { get; set; }
        public int Sucursal_Id { get; set; }
        public string Sucursal_Descripcion { get; set; }
        public string Membresia_Fecha_Inicio { get; set; }
        public int Meses_Adelantados { get; set; }
        public int Lista_Precio_Id { get; set; }
        public int Moneda_Id { get; set; }
        public int Impuesto_Id { get; set; }
        public int Descuento_Id { get; set; }
        public string Tipo { get; set; }

    }
}
