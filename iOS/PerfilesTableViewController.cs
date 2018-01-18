using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using Foundation;

namespace WorklabsMx.iOS
{
    public partial class PerfilesTableViewController : UITableViewController
    {
        public List<string> ListUser = new List<string>();
        MiembrosController Favorites = new MiembrosController();
        MiembroModel Miembro = new MiembroModel();

        bool FromMi = true, FromSocial = false, FromTrabajo = false;

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
                this.btnProfileImage.SetBackgroundImage(ImageGallery.LoadImage(Miembro.Miembro_Fotografia) ?? UIImage.FromBundle("ProfileImageBig"), UIControlState.Normal);
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
            this.cvwMi.Hidden = false;
            this.cvwSocial.Hidden = true;
            this.cvwTrabajo.Hidden = true;
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
            this.TableView.ScrollToRow(NSIndexPath.FromRowSection(1, 0), UITableViewScrollPosition.None, true);
        }

        partial void btnSobreMi_Touch(UIButton sender)
        {
            this.cvwMi.Hidden = false;
            this.cvwSocial.Hidden = true;
            this.cvwTrabajo.Hidden = true;
            this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwMi.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromSocial)
            {
                this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
                this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
            }
            else if (FromTrabajo)
            {
                this.btnTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnTrabajo.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            this.FromMi = true;
            this.FromSocial = false;
            this.FromTrabajo = false;
        }

        partial void btnSocial_Touch(UIButton sender)
        {
            this.cvwMi.Hidden = true;
            this.cvwSocial.Hidden = false;
            this.cvwTrabajo.Hidden = true;
            this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromMi)
            {
                this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
                this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwMi.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
            }
            else if (FromTrabajo)
            {
                this.btnTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnTrabajo.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            this.FromMi = false;
            this.FromSocial = true;
            this.FromTrabajo = false;
        }

        partial void btnTrabajo_Touch(UIButton sender)
        {
            this.cvwMi.Hidden = true;
            this.cvwSocial.Hidden = true;
            this.cvwTrabajo.Hidden = false;
            this.btnTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnTrabajo.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromMi)
            {
                this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwMi.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            else if (FromSocial)
            {
                this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
                this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
            }
            this.FromMi = false;
            this.FromSocial = false;
            this.FromTrabajo = true;
        }
    }
}