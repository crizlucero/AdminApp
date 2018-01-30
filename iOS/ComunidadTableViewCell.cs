using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{

    public interface EventosComunidadCell
    {
        void InfoUserPost(List<String> listaUser);
    }

    public partial class ComunidadTableViewCell : UITableViewCell
    {
        UsuariosController Favorites;

        UsuarioModel MiembroLocal;

        public EventosComunidadCell EventosComunidadCellDelegate;

        public ComunidadTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(UsuarioModel Miembro)
        {
            Favorites = new UsuariosController();
            this.lblNombre.Text = Miembro.Usuario_Nombre + " " + Miembro.Usuario_Apellidos;
            this.lblProfesion.Text = Miembro.Usuario_Profesion;
            var isFavorite = Favorites.IsMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Miembro.Usuario_Id, Miembro.Usuario_Tipo);
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
            List<String> listaUser = new List<string>();
            listaUser.Add(MiembroLocal.Usuario_Id);
            listaUser.Add(MiembroLocal.Usuario_Empresa_Nombre);
            listaUser.Add(MiembroLocal.Usuario_Tipo);
            EventosComunidadCellDelegate.InfoUserPost(listaUser);
        }
    }
}