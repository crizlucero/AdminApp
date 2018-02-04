using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoInfoCellUsuarios : UITableViewCell
    {
        public NoInfoCellUsuarios (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                lblNoInfo.Text = "";
            }
            else
            {
                lblNoInfo.Text = "";
            }
        }
    }
}