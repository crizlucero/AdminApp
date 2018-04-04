using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoSalasCell : UITableViewCell
    {
        public NoSalasCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(string Mensaje)
        {
            lblNoSalas.Text = Mensaje;
        }

    }
}