using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class ComentariosHeaderCell : UITableViewCell
    {
        public ComentariosHeaderCell (IntPtr handle) : base (handle)
        {
            
        }

        internal void UpdateCell(MiembroModel miembro)
        {
            lblNombre.Text = miembro.Miembro_Nombre;
            lblProfesion.Text = miembro.Miembro_Profesion;
            //imgPerfil.Image = miembro.Miembro_Fotografia;
        }

    }
}