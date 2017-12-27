using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class MenuContenidoCell : UITableViewCell
    {
        public MenuContenidoCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(string Label)
        {
            this.lblMenuNombre.Text = Label;
        }


    }
}