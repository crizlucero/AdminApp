using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Models;
using System.Threading.Tasks;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;

namespace WorklabsMx.iOS
{

    public interface EventosComunidadCell
    {
        void InfoUserPost(UsuarioModel Miembro);
    }

    public partial class ComunidadTableViewCell : UITableViewCell
    {
        UsuariosController Favorites;

        UsuarioModel MiembroLocal;

        public EventosComunidadCell EventosComunidadCellDelegate;

        public ComunidadTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public async void UpdateCell(UsuarioModel Miembro)
        {
            Favorites = new UsuariosController();
            this.lblNombre.Text = Miembro.Usuario_Nombre + " " + Miembro.Usuario_Apellidos;
            this.lblProfesion.Text = Miembro.Usuario_Profesion;
            var isFavorite = Favorites.IsMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Miembro.Usuario_Id, Miembro.Usuario_Tipo);
            if(isFavorite.Value)
            {
                this.btnFavorito.Enabled = true;
                this.btnFavorito.Hidden = false;
            }
            else
            {
                this.btnFavorito.Enabled = false;
                this.btnFavorito.Hidden = true;
            }
            this.MiembroLocal = Miembro;
            await GetImagenesPost(Miembro);
        }


        async Task GetImagenesPost(UsuarioModel Usuario)
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
                    else if (Usuario.Usuario_Fotografia_Perfil.Length == 0)
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
            btnImagenComunidad.SetBackgroundImage(ReescalImage, UIControlState.Normal);
        }

        partial void btnFavorito_Touch(UIButton sender)
        {
            
        }

        partial void btnImagenComu_Touch(UIButton sender)
        {
            EventosComunidadCellDelegate.InfoUserPost(this.MiembroLocal);
        }
    }
}