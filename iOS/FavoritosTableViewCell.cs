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
            List<String> listaUser = new List<string>();
            listaUser.Add(MiembroLocal.Miembro_Id);
            listaUser.Add(MiembroLocal.Miembro_Empresa);
            listaUser.Add(MiembroLocal.Miembro_Tipo);
            EventosFavoritosCellDelegate.InfoUserPost(listaUser);
        }        
    }
}