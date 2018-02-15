using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class RedesSocialesTableViewCell : UITableViewCell
    {
        public RedesSocialesTableViewCell (IntPtr handle) : base (handle)
        {
            
        }

        public void UpdateCell(RedSocialModel RedSocial)
        {
            this.lblRedSocial.Text = (RedSocial.Red_Social_Nombre != "") ? RedSocial.Red_Social_Nombre : "Sin Info";
        }
    }
}