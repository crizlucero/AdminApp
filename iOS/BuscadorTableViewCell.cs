using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class BuscadorTableViewCell : UITableViewCell
    {
        public BuscadorTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell()
        {
            //this.txtBuscar.AttributedPlaceholder = new NSAttributedString("Busca un contacto", null, UIColor.Clear.FromHex(0x8E8E93));
        }

    }
}