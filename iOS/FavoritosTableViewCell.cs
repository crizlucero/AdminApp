using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using CoreGraphics;
using System.Collections.Generic;


namespace WorklabsMx.iOS
{
    public partial class FavoritosTableViewCell : UITableViewCell
    {
        public event EventHandler InfoUserPost;

        MiembroModel MiembroLocal;

        public FavoritosTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(MiembroModel Miembro)
        {
            this.lblNombre.Text = Miembro.Miembro_Nombre + " " + Miembro.Miembro_Apellidos;
            this.lblProfesion.Text = Miembro.Miembro_Profesion;
            this.MiembroLocal = Miembro;
        }

        partial void btnImagenFav_Touch(UIButton sender)
        {
            if (InfoUserPost != null)
            {
                List<String> listaUser = new List<string>();
                listaUser.Add(MiembroLocal.Miembro_Id);
                listaUser.Add(MiembroLocal.Miembro_Empresa);
                listaUser.Add(MiembroLocal.Miembro_Tipo);
                listaUser.Add(MiembroLocal.Miembro_Fotografia);
                InfoUserPost(listaUser, EventArgs.Empty);
            }
        }
    }
}