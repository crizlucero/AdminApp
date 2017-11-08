using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class HeaderCarritoProductos : UITableViewCell
    {
        public HeaderCarritoProductos (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(double TotalPagar, int TotalProductos)
        {
            this.lblNumeroProductos.Text = TotalProductos.ToString();
            this.lblTotalPagar.Text = TotalPagar.ToString("C");
        }
    }
}