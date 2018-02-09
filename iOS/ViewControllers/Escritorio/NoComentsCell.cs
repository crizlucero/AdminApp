using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoComentsCell : UITableViewCell
    {
        public NoComentsCell (IntPtr handle) : base (handle)
        {
            
        }

		internal void UpdateCell(bool existeConeccion)
		{
            if(existeConeccion){
                lblMessageNoComments.Text = "";
            } else {
                lblMessageNoComments.Text = "";
            }
		}
    }
}