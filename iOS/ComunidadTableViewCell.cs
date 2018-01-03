using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class ComunidadTableViewCell : UITableViewCell
    {
        MiembrosController Favorites;
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
        }

        partial void btnFavorito_Touch(UIButton sender)
        {
            
        }

        partial void btnImagenComu_Touch(UIButton sender)
        {
            
        }
    }
}