using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;
using WorklabsMx.iOS.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{

    public interface EventosCeldaLike
    {
        
    }

    public partial class CeldaLike : UITableViewCell
    {
        KeyValuePair<int, bool> isFavorite;
        string Usuario_Id;
        string Usuario_Tipo;

        public CeldaLike(IntPtr handle) : base(handle)
        {
        }

        public async void UpdateCell(UsuarioModel usuario)
        {
            this.Usuario_Id = usuario.Usuario_Id;
            this.Usuario_Tipo = usuario.Usuario_Tipo;
            UsuariosController Favorites = new UsuariosController();
            this.lblNombre.Text = usuario.Usuario_Nombre + " " + usuario.Usuario_Apellidos;
            this.lblOcupacion.Text = usuario.Usuario_Empresa_Nombre;
            isFavorite = Favorites.IsMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), usuario.Usuario_Id, usuario.Usuario_Tipo);
            if (isFavorite.Value || (KeyChainHelper.GetKey("Usuario_Id") == usuario.Usuario_Id && KeyChainHelper.GetKey("Usuario_Tipo") == usuario.Usuario_Tipo))
            {
                btnSeguir.Hidden = true;
                btnSeguir.Enabled = false;
            }
            else
            {
                btnSeguir.Hidden = false;
                btnSeguir.Enabled = true;
            }
            await GetImagenesPost(usuario);
        }

        partial void btnSeguir_Touch(UIButton sender)
        {
            this.AsignarFavorito();
        }

        private void AsignarFavorito()
        {
            if(InternetConectionHelper.VerificarConexion())
            {
                var result = new UsuariosController().AddMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.Usuario_Id, this.Usuario_Tipo);
                if (result)
                {
                    btnSeguir.Hidden = true;
                    btnSeguir.Enabled = false;
                }

            }
           
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
            btnImagenPerfil.SetBackgroundImage(ReescalImage, UIControlState.Normal);
        }


    }
}