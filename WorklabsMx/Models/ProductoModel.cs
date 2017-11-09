namespace WorklabsMx.Models
{
    public class ProductoModel
    {
        public string Producto_Id { get; set; }
        public string Producto_Descripcion { get; set; }
        public string Producto_Disponibilidad { get; set; }
        public double Producto_Precio_Base { get; set; }
        public double Producto_Precio_Base_Neto { get; set; }
        public double Producto_Precio_Prorrateo { get; set; }
        //Datos Generales
        public int Lista_Precio_Id { get; set; }
        public int Moneda_Id { get; set; }
        public int Impuesto_Id { get; set; }
        public int Descuento_Id { get; set; }
    }
}
