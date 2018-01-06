using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class HeaderEmpresasCell : UITableViewCell
    {
        public HeaderEmpresasCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell()
        {
            //this.txtBuscarEmpresa.AttributedPlaceholder = new NSAttributedString("Busca un contacto", null, UIColor.Clear.FromHex(0x8E8E93));
        }

    }
}