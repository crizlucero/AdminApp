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
    public partial class ComunidadTableViewCell : UITableViewCell
    {
        MiembrosController Favorites;
        public event EventHandler InfoUserPost;
        MiembroModel MiembroLocal;

        public ComunidadTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(MiembroModel Miembro)
        {
            Favorites = new MiembrosController();
            this.lblNombre.Text = Miembro.Miembro_Nombre + " " + Miembro.Miembro_Apellidos;
            this.lblProfesion.Text = Miembro.Miembro_Profesion;
            var isFavorite = Favorites.IsMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Miembro.Miembro_Id, Miembro.Miembro_Tipo);
            if(isFavorite.Value)
            {
                this.btnFavorito.Enabled = true;
                this.btnFavorito.Hidden = false;
            }
            else
            {
                this.btnFavorito.Enabled = false;
                this.btnFavorito.Hidden = true;
            }
            this.MiembroLocal = Miembro;
        }

        partial void btnFavorito_Touch(UIButton sender)
        {
            
        }

        partial void btnImagenComu_Touch(UIButton sender)
        {
            if (InfoUserPost != null)
            {
                //string[] ArrayUserPost = { PostLocal.Miembro_Id, PostLocal.Colaborador_Empresa_Id, PostLocal.Usuario_Tipo};
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