using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using System.Threading.Tasks;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class HeaderMenulCell : UITableViewCell
    {
        public HeaderMenulCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell()
        {
            var miembro = MenuHelper.UserInfo;
            if (miembro != null)
            {
                if (miembro.Count > 0)
                {
                    lblNombre.Text = miembro[(int)CamposMiembro.Usuario_Nombre];
                    lblPuesto.Text = miembro[(int)CamposMiembro.Usuario_Puesto];
                    btnImagenPerfil.SetBackgroundImage(ImageGallery.LoadImage(miembro[(int)CamposMiembro.Usuario_Fotografia]) ?? UIImage.FromBundle("ProfileImageBig"), UIControlState.Normal);
                }

            }
        }

    }
}