using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class CeldaProductos : UICollectionViewCell
    {
        public CeldaProductos (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(ProductoModel Producto)
        {
            this.lblNombreProducto.Text = Producto.Producto_Descripcion;
        }
    }
}