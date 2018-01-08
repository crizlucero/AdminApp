using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class PerfilesTableViewController : UITableViewController
    {
        public List<string> ListUser = new List<string>();
        MiembrosController Favorites = new MiembrosController();
        MiembroModel Miembro = new MiembroModel();

        public PerfilesTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if (InternetConectionHelper.VerificarConexion())
            {
                
                this.Miembro = new MiembrosController().GetMemberData((ListUser[0] != "") ? ListUser[0] : ListUser[1], ListUser[2]);
                this.lblNombre.Text = (Miembro.Miembro_Nombre != "") ? Miembro.Miembro_Nombre : "Sin Info";
                this.lblEmpresa.Text = (Miembro.Miembro_Empresa != null) ? Miembro.Miembro_Empresa : "Sin Info";
                this.btnProfileImage.SetBackgroundImage(ImageGallery.LoadImage(ListUser[3]) ?? UIImage.FromBundle("ProfileImageBig"), UIControlState.Normal);
                KeyValuePair<int, bool> isFavorite = Favorites.IsMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Miembro.Miembro_Id, Miembro.Miembro_Tipo);
                if (isFavorite.Key == 0)
                {
                    this.btnSeguir.SetTitle("+ Seguir", UIControlState.Normal);
                }
                else 
                {
                    this.btnSeguir.SetTitle("- Dejar de seguir", UIControlState.Normal); 
                }
            }
        }

        partial void btnBackGroundImage_Touch(UIButton sender)
        {
        }

        partial void btnImageProfile(UIButton sender)
        {
        }

        partial void btnSeguir_Touch(UIButton sender)
        {
            if (InternetConectionHelper.VerificarConexion())
            {
                KeyValuePair<int, bool> isFavorite = Favorites.IsMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Miembro.Miembro_Id, Miembro.Miembro_Tipo);
                if (isFavorite.Key == 0)
                {
                    if (Favorites.AddMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Miembro.Miembro_Id, Miembro.Miembro_Tipo))
                    {
                        this.btnSeguir.SetTitle("Dejar de seguir", UIControlState.Normal);
                    }
                    else
                    {
                        new MessageDialog().SendToast("Error de conexión, intente más tarde");
                    }
                }
                else
                {
                    if (Favorites.RemoveMiembroFavorito(isFavorite))
                    {
                        this.btnSeguir.SetTitle("Seguir", UIControlState.Normal);
                    }
                    else
                    {
                        new MessageDialog().SendToast("Error de conexión, intente más tarde");
                    }
                }
            }
            else 
            {
                new MessageDialog().SendToast("Error de conexión, intente más tarde");
            }
        }

        partial void btnEnviarMensaje_Touch(UIButton sender)
        {
        }

        partial void btnVerMas_Touch(UIButton sender)
        {
        }

        partial void btnSobreMi_Touch(UIButton sender)
        {
        }

        partial void btnSocial_Touch(UIButton sender)
        {
        }

        partial void btnTrabajo_Touch(UIButton sender)
        {
        }
    }
}