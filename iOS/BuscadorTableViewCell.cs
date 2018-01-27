using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{


    public interface EventoBuscador
    {
        void Buscando(string Texto);
    }

    public partial class BuscadorTableViewCell : UITableViewCell
    {

        public EventoBuscador EventoBuscadorDelegate;

        public BuscadorTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell()
        {
            //this.txtBuscar.AttributedPlaceholder = new NSAttributedString("Busca un contacto", null, UIColor.Clear.FromHex(0x8E8E93));
            srbComunidad.TextChanged += (sender, e) => {
                EventoBuscadorDelegate.Buscando(e.SearchText);
            };
        }



    }
}