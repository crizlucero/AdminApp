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
            if (miembro != null)
            {
				lblNombre.Text = miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos;
				lblProfesion.Text = miembro.Miembro_Profesion;
				//imgPerfil.Image = miembro.Miembro_Fotografia;
			}
            else
            {
                lblNombre.Text = "Gilberto Escareño Barrera";
                lblProfesion.Text = "Desarrollador";
            }

        }

    }
}