using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class HeaderFavoritosTableViewCell : UITableViewCell
    {

        public event EventHandler Buscando;

        public HeaderFavoritosTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell()
        {
            srbFavoritos.TextChanged += (sender, e) => {
                if (Buscando != null)
                {
                    Buscando(e.SearchText, EventArgs.Empty);
                }
            };
        }

    }
}