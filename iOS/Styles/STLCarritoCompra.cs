using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace WorklabsMx.iOS.Styles
{
    public class STLCarritoCompra : UITableViewCell
    {
        readonly UILabel lblCantidad, lblDescripcion, lblTotal;
        public STLCarritoCompra(NSString cellId) : base(UITableViewCellStyle.Default, cellId)
        {
            lblCantidad = new UILabel
            {

            };

            lblDescripcion = new UILabel
            {

            };

            lblTotal = new UILabel
            {
            };

            ContentView.AddSubviews(new UIView[] { lblCantidad, lblDescripcion, lblTotal });
        }

        public void UpdateCell(string cantidad, string descripcion, string total)
        {
            lblCantidad.Text = cantidad;
            lblDescripcion.Text = descripcion;
            lblTotal.Text = total;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            lblCantidad.Frame = new CGRect(0, 30, UIScreen.MainScreen.Bounds.Width / 4, 30);
            lblDescripcion.Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 30, UIScreen.MainScreen.Bounds.Width / 2, 30);
            lblTotal.Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 30, UIScreen.MainScreen.Bounds.Width / 4, 30);
        }
    }
}
