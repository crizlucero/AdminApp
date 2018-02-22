using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class CeldaColaboradores : UICollectionViewCell
    {
        public CeldaColaboradores (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(UsuarioModel Colaborador)
        {
            var ImagenPerfil = this.GetImage(Colaborador.Usuario_Fotografia_Perfil);
            if (ImagenPerfil != null)
            {
                this.imgColaboradores.Image = ImagenPerfil;
            }
            else
            {
                this.imgColaboradores.Image = UIImage.FromBundle("ProfileImageBig");
            }

            this.lblNombre.Text = Colaborador.Usuario_Nombre;
            this.lblApellidos.Text = Colaborador.Usuario_Apellidos;
        }

        private UIImage GetImage(byte[] Imagen)
        {
            if (Imagen != null)
            {
                var data = NSData.FromArray(Imagen);
                var uiimage = UIImage.LoadFromData(data);
                return uiimage;
            }
            return null;
        }

    }
}