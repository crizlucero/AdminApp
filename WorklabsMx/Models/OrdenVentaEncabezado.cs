using System;
using SQLite;

namespace WorklabsMx.Models
{
    public class OrdenVentaEncabezado
    {
        [PrimaryKey, AutoIncrement]
        public string Orden_Venta_Encabezado_Id { get; set; }
        public UsuarioModel Usuario { get; set; }
        public int Moneda_Id { get; set; }
        public int Impuesto_Id { get; set; }
        public int Promocion_Id { get; set; }
        public int Descuento_Id { get; set; }
        public string Folio { get; set; }
        public decimal Importe_Suma { get; set; }
        public decimal Porcentaje_Descuento { get; set; }
        public decimal Importe_Descuento { get; set; }
        public decimal Importe_Subtotal { get; set; }
        public decimal Importe_Impuesto { get; set; }
        public decimal Importe_Total { get; set; }
        public decimal Importe_Pagado { get; set; }
        public decimal Importe_Facturado { get; set; }

        public override string ToString() => string.Format("[OrdenVentaEncabezado: Orden_Venta_Encabezado_Id={0}, Usuario_Id={1}, Moneda_Id={2}, Impuesto_Id={3}, Promocion_Id={4}, " +
                                 "Descuento_Id={5}, Folio={6}, Importe_Suma={7}, Porcentaje_Descuento={8}, Importe_Descuento={9}, Importe_Subtotal={10},  " +
                                 "Importe_Impuesto={11}, Importe_Total={12}, Importe_Pagado={13}, Importe_Facturado={14}]",
                                 Orden_Venta_Encabezado_Id, Usuario.Usuario_Id, Moneda_Id, Impuesto_Id, Promocion_Id, Descuento_Id, Folio, Importe_Suma,
                                 Porcentaje_Descuento, Importe_Descuento, Importe_Subtotal, Importe_Impuesto, Importe_Total, Importe_Pagado, Importe_Facturado);
    }
}

