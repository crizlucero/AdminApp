using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using PerpetualEngine.Storage;
using System.Data;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;

namespace WorklabsMx.iOS
{
    public partial class ComentariosHeaderCell : UITableViewCell
    {

        public ComentariosHeaderCell (IntPtr handle) : base (handle)
        {
            
        }

        internal void UpdateCell(List<string> miembro)
        {
            if (miembro != null)
            {
                lblNombre.Text = miembro[(int)CamposMiembro.Usuario_Nombre].ToString();
                lblProfesion.Text = miembro[(int)CamposMiembro.Usuario_Puesto].ToString();
                imgPerfil.Image = ImageGallery.LoadImage(miembro[(int)CamposMiembro.Usuario_Fotografia]);

			}
            else
            {
                lblNombre.Text = "Gilberto Escareño Barrera";
                lblProfesion.Text = "Desarrollador";
            }

        }

        public UIImageView getImagenPerfil()
        {
            return this.imgPerfil;
        }

		partial void BtnPublicar_TouchUpInside(UIButton sender)
		{
            
		}


    }
}