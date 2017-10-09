using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using PerpetualEngine.Storage;
using System.Data;
using System.Collections.Generic;

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
                lblNombre.Text = miembro[0].ToString();
                //miembro["Usuario_Fotografia"].ToString().Replace(@"\", "/");
                lblProfesion.Text = miembro[2].ToString();
				
				//imgPerfil.Image = miembro.Miembro_Fotografia;
			}
            else
            {
                lblNombre.Text = "Gilberto Escareño Barrera";
                lblProfesion.Text = "Desarrollador";
            }

        }

		partial void BtnPublicar_TouchUpInside(UIButton sender)
		{
		    
		}

       


    }
}