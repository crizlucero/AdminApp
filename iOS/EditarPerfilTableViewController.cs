using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Enum;
using Foundation;
using System.Text.RegularExpressions;
using BigTed;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class EditarPerfilTableViewController : UITableViewController
    {

        MiembroModel Miembro = new MiembroModel();
        public EditarPerfilTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.txtNombre.AttributedPlaceholder = new NSAttributedString("  Nombre", null, UIColor.Clear.FromHex(0xFFFFFF));
            this.txtProfesion.AttributedPlaceholder = new NSAttributedString("   Puesto", null, UIColor.Clear.FromHex(0xFFFFFF));
            var miembro = new MiembrosController().GetMemberName(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
            if (miembro != null)
            {
                if (miembro.Count > 0)
                {
                    txtNombre.Text = miembro[(int)CamposMiembro.Usuario_Nombre];
                    txtProfesion.Text = miembro[(int)CamposMiembro.Usuario_Puesto];
                    btnImagen.SetBackgroundImage(ImageGallery.LoadImage(miembro[(int)CamposMiembro.Usuario_Fotografia]) ?? UIImage.FromBundle("ProfileImageBig"), UIControlState.Normal);
                }

            }
        }

        partial void FondoImagen_Touch(UIButton sender)
        {
        }

        partial void btnImagen_Touch(UIButton sender)
        {
        }
    }
}