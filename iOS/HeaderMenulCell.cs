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
            var Usuario = MenuHelper.Usuario;
            if (Usuario != null)
            {
                lblNombre.Text = Usuario.Usuario_Nombre;
                lblPuesto.Text = Usuario.Usuario_Puesto;
                if (Usuario.Usuario_Fotografia_Perfil != null)
                {

                    var data = NSData.FromArray(Usuario.Usuario_Fotografia_Perfil);
                    this.btnImagenPerfil.SetBackgroundImage(UIImage.LoadFromData(data), UIControlState.Normal);
                }
                else
                {
                    this.btnImagenPerfil.SetBackgroundImage(UIImage.FromBundle("ProfileImageBig"), UIControlState.Normal);
                }
            }
        }

    }
}