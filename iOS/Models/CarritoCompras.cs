﻿namespace WorklabsMx.iOS.Models
{
    public class CarritoCompras
    {
        public string Tipo { get; set; }
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int Meses { get; set; }
        public string FechaInicio { get; set; }
        public int ListaPrecioId { get; set; }
        public int MonedaId { get; set; }
        public int ImpuestoId { get; set; }
        public object DescuentoId { get; set; }
        public string TotalPagar { get; set; }
        public int IndiceProducto { get; set; }
        public string Nombre { get; set; }
    }
}
