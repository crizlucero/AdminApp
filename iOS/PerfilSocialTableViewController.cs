using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;


namespace WorklabsMx.iOS
{
    public partial class PerfilSocialTableViewController : UIViewController
    {
        public List<RedSocialModel> Redes_Sociales;

        public UsuarioModel Miembro = new UsuarioModel();

        public PerfilSocialTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.lblSiguiendo.Text = (Miembro.Red_Social_Siguiendo != "" && Miembro.Red_Social_Siguiendo != null) ? Miembro.Red_Social_Siguiendo : "0";
            this.lblPublicaciones.Text = (Miembro.Red_Social_Publicaciones != "" && Miembro.Red_Social_Publicaciones != null) ? Miembro.Red_Social_Publicaciones : "0";
            this.lblSeguidores.Text = (Miembro.Red_Social_Seguidores != "" && Miembro.Red_Social_Seguidores != null) ? Miembro.Red_Social_Seguidores : "0";
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SobreMi")
            {
                var InfoPeril = (PerfilRedesSociales)segue.DestinationViewController;
                InfoPeril.Redes_Sociales = Redes_Sociales;
            }
 
        }


    }
}