using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class InvitadoTableViewCell : UITableViewCell
    {
        public InvitadoTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell()
        {
            txtApellido.AttributedPlaceholder = new NSAttributedString("APELLIDO", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
           txtNombre.AttributedPlaceholder = new NSAttributedString("NOMBRE", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
           txtEmail.AttributedPlaceholder = new NSAttributedString("EMAIL", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
        }

    }
}