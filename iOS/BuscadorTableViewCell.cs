using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class BuscadorTableViewCell : UITableViewCell
    {

        public event EventHandler Buscando;

        public BuscadorTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell()
        {
            //this.txtBuscar.AttributedPlaceholder = new NSAttributedString("Busca un contacto", null, UIColor.Clear.FromHex(0x8E8E93));
            srbComunidad.TextChanged += (sender, e) => {
                if (Buscando != null)
                {
                    Buscando(e.SearchText, EventArgs.Empty);
                }
            };
        }



    }
}