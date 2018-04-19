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
            if (Producto.Producto_Id == "2")
            {
                this.imgProductos.Image = UIImage.FromBundle("CopiaNegro");
            }
            if (Producto.Producto_Id == "3")
            {
                this.imgProductos.Image = UIImage.FromBundle("CopiaColor");
            }
            if (Producto.Producto_Id == "4")
            {
                this.imgProductos.Image = UIImage.FromBundle("Telefonia");
            }
        }
    }
}