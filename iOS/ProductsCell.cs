using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class ProductsCell : UICollectionViewCell
    {
        public ProductsCell (IntPtr handle) : base (handle)
        {
            StyleHelper.Style(this.Layer);
        }

        public override void LayoutIfNeeded()
        {
            base.LayoutIfNeeded();

        }

        internal void UpdateCell(ProductoModel Producto)
        {
            var mensaje = "";

            if (Producto.Producto_Disponibilidad.Contains("RECURRENTE"))
            {
                mensaje = "Tarifa Mensual: $";
            }
            else
            {
                mensaje = "Tarifa de pago único: $";
            }
            lblNombreProducto.Text = Producto.Producto_Descripcion;
            lblDescripcionProducto.Text = mensaje + Producto.Producto_Precio_Base.ToString();
        }
    }


}