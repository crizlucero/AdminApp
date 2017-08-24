using System;
namespace WorklabsMx.Models
{
    public class CarritoModel
    {
        public string Pedido_Id { get; set; }
        public string Miembro_Id { get; set; }
        public string Producto_Id { get; set; }
        public double Producto_Cantidad { get; set; }
        public string Membresia_Id { get; set; }
        public string Membresia_Cantidad { get; set; }
        public string Pedido_Estatus { get; set; }
        public string Precio_Base { get; set; }
        public string Dias_Prorrateo { get; set; }
        public string Pedido_Total { get; set; }

    }
}
