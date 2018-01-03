using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;


namespace WorklabsMx.iOS
{
    public partial class FavoritosTableViewCell : UITableViewCell
    {
        
        public FavoritosTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(MiembroModel Miembro)
        {
            this.lblNombre.Text = Miembro.Miembro_Nombre + " " + Miembro.Miembro_Apellidos;
            this.lblProfesion.Text = Miembro.Miembro_Profesion;
        }

        partial void btnImagenFav_Touch(UIButton sender)
        {
            
        }
    }
}