using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using System.Threading.Tasks;


namespace WorklabsMx.iOS
{
    public partial class HeaderMenulCell : UITableViewCell
    {
        public HeaderMenulCell (IntPtr handle) : base (handle)
        {
        }

        public async void UpdateCell()
        {
            var Usuario = MenuHelper.Usuario;
            if (Usuario != null)
            {
                lblNombre.Text = Usuario.Usuario_Nombre + " " + Usuario.Usuario_Apellidos;
                lblPuesto.Text = Usuario.Usuario_Profesion;
                await GetImagen(Usuario);
            }
        }

        async Task GetImagen(UsuarioModel Usuario)
        {
            UIImage ReescalImage = new UIImage();
            if ((Usuario.Usuario_Fotografia != "" && Usuario.Usuario_Fotografia != null && Usuario.Usuario_Fotografia != "user_male.png"))
            {
                await Task.Run(() =>
                {
                    if (Usuario.Usuario_Fotografia_Perfil == null)
                    {
                        Usuario.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(Usuario.Usuario_Fotografia, MenuHelper.ProfileImagePath);
                    }

                    if (Usuario.Usuario_Fotografia_Perfil.Length == 0)
                    {
                        ReescalImage = UIImage.FromBundle("PerfilEscritorio");
                    }
                    else
                    {
                        var data = NSData.FromArray(Usuario.Usuario_Fotografia_Perfil);
                        var uiimage = UIImage.LoadFromData(data);
                        ReescalImage = uiimage;
                    }


                });
            }
            else
            {
                ReescalImage = UIImage.FromBundle("PerfilEscritorio");
            }
            this.btnImagenPerfil.SetBackgroundImage(ReescalImage, UIControlState.Normal);
        }

    }
}