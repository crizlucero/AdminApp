using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;


namespace WorklabsMx.iOS
{

    public interface EventosFavoritosCell
    {
        void InfoUserPost(List<String> listaUser);
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
            List<String> listaUser = new List<string>();
            listaUser.Add(MiembroLocal.Usuario_Id);
            listaUser.Add(MiembroLocal.Usuario_Empresa_Nombre);
            listaUser.Add(MiembroLocal.Usuario_Tipo);
            EventosFavoritosCellDelegate.InfoUserPost(listaUser);
        }        
    }
}