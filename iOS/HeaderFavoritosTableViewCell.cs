using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

    public interface EventosBuscar
    {
        void Buscando(string SearchText);
    }

    public partial class HeaderFavoritosTableViewCell : UITableViewCell
    {

        public EventosBuscar EventosBuscarDelegate;

        public HeaderFavoritosTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell()
        {
            srbFavoritos.TextChanged += (sender, e) => {
                EventosBuscarDelegate.Buscando(e.SearchText);
            };
        }

    }
}