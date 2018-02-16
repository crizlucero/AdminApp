using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;


namespace WorklabsMx.iOS
{

    public interface EventosFavoritosCell
    {
        void InfoUserPost(UsuarioModel listaUser);
    }

    public partial class FavoritosTableViewCell : UITableViewCell
    {
        public EventosFavoritosCell EventosFavoritosCellDelegate;
        UsuarioModel MiembroLocal;

        public FavoritosTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(UsuarioModel Miembro)
        {
            this.lblNombre.Text = Miembro.Usuario_Nombre + " " + Miembro.Usuario_Apellidos;
            this.lblProfesion.Text = Miembro.Usuario_Profesion;
            this.MiembroLocal = Miembro;
        }

        partial void btnImagenFav_Touch(UIButton sender)
        {
            EventosFavoritosCellDelegate.InfoUserPost(this.MiembroLocal);
        }        
    }
}