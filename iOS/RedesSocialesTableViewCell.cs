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
            this.lblRedSocial.Text = (RedSocial.Red_Social_Enlace != "") ? RedSocial.Red_Social_Enlace : "Sin Info";
            if (RedSocial.Red_Social_Id == "1")
            {
                imgImagenRedSocial.Image = UIImage.FromBundle("Web");
            }
            if (RedSocial.Red_Social_Id == "2")
            {
                imgImagenRedSocial.Image = UIImage.FromBundle("facebookic");
            }
            if (RedSocial.Red_Social_Id == "3")
            {
                imgImagenRedSocial.Image = UIImage.FromBundle("ic_instagram");
            }
            if (RedSocial.Red_Social_Id == "4")
            {
                imgImagenRedSocial.Image = UIImage.FromBundle("icTwitter");
            }
            if (RedSocial.Red_Social_Id == "5")
            {
                imgImagenRedSocial.Image = UIImage.FromBundle("LinkEdin"); 
            }
            if (RedSocial.Red_Social_Id == "6")
            {
                imgImagenRedSocial.Image = UIImage.FromBundle("Skype"); 
            }
            if (RedSocial.Red_Social_Id == "7")
            {
                imgImagenRedSocial.Image = UIImage.FromBundle("google"); 
            }

            if (RedSocial.Red_Social_Id == "8")
            {
                imgImagenRedSocial.Image = UIImage.FromBundle("YouTube");
            }
            if (RedSocial.Red_Social_Id == "9")
            {
                imgImagenRedSocial.Image = UIImage.FromBundle("Spotify");
            }
            if (RedSocial.Red_Social_Id == "10")
            {
                imgImagenRedSocial.Image = UIImage.FromBundle("Quora");
            }

        }
    }
}