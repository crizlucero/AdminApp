using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using WorklabsMx.Helpers;
using System.Collections.Generic;
using Foundation;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{

    public interface Perfilesint
    {
        void InfoActualizar();
    }

    public partial class PerfilesTableViewController : UITableViewController
    {
        public UsuarioModel Miembro = new UsuarioModel();

        public Perfilesint PerfilesDelegate;

        bool FromMi = true, FromSocial = false, FromTrabajo = false;

        public bool InfoPersonal;

        bool result;
        KeyValuePair<int, bool> isFavorite;

        public PerfilesTableViewController (IntPtr handle) : base (handle)
        {
            //this.Miembro = MenuHelper.Usuario;
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            await PreguntarFavorito();
            if (InfoPersonal)
            {
                this.btnSeguir.Hidden = true;
                this.btnEnviarMensaje.Hidden = true;
                this.btnEditarPerfil.Hidden = false;

                this.btnSeguir.Enabled = false;
                this.btnEnviarMensaje.Enabled = false;
                this.btnEditarPerfil.Enabled = true;
            }
            else
            {
                this.btnSeguir.Hidden = false;
                this.btnEnviarMensaje.Hidden = false;
                this.btnEditarPerfil.Hidden = true;

                this.btnSeguir.Enabled = true;
                this.btnEnviarMensaje.Enabled = true;
                this.btnEditarPerfil.Enabled = false;
            }
            this.CargarInfo();
            this.cvwMi.Hidden = false;
            this.cvwSocial.Hidden = true;
            this.cvwTrabajo.Hidden = true;

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

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
           
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }


        public override void LoadView()
        {
            base.LoadView();
            this.CargarInfo();
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

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SobreMi")
            {
                var InfoPeril = (MiInfoView)segue.DestinationViewController;
                InfoPeril.Miembro = this.Miembro;
            }
            else if(segue.Identifier == "Social")
            {
                var InfoSocial = (PerfilSocialTableViewController)segue.DestinationViewController;
                InfoSocial.Redes_Sociales = this.Miembro.Redes_Sociales;
                InfoSocial.Miembro = this.Miembro;
            }
            else if (segue.Identifier == "Trabajo")
            {
                var InfoPeril = (InfoEmpresaTableViewController)segue.DestinationViewController;
                InfoPeril.Miembro = this.Miembro;
            }
            else if (segue.Identifier == "EditarPerfil")
            {
                var EditarPerfil = (EditarPerfilTableViewController)segue.DestinationViewController;
                EditarPerfil.InfoPerifl = this.Miembro;
                EditarPerfil.MiInfoDeleghate = this;
            }
        }

        public async void CargarInfo()
        {
            this.lblNombre.Text = (Miembro.Usuario_Nombre + " " + Miembro.Usuario_Apellidos != "") ? Miembro.Usuario_Nombre + " " + Miembro.Usuario_Apellidos : "Sin Info";
            if (Miembro.Empresa_Actual != null)
            {
                this.lblEmpresa.Text = (Miembro.Empresa_Actual.Empresa_Nombre != null) ? Miembro.Empresa_Actual.Empresa_Nombre : "Sin Info";
            }
            else
            {
                this.lblEmpresa.Text = "Sin Info";
            }

            await GetImages(Miembro);


        }

        async Task GetImages(UsuarioModel Miembro)
        {
            UIImage ReescalImageBack = new UIImage();
            UIImage ReescalImageUsr = new UIImage();
            await Task.Run(() =>
            {
                
                if ((Miembro.Usuario_Fotografia != "" && Miembro.Usuario_Fotografia != null  && Miembro.Usuario_Fotografia != "user_male.png"))
                {
                    if (Miembro.Usuario_Fotografia_Perfil == null)
                    {
                        Miembro.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(Miembro.Usuario_Fotografia, MenuHelper.ProfileImagePath);
                    }
                    if (Miembro.Usuario_Fotografia_Perfil.Length == 0)
                    {
                        ReescalImageUsr = UIImage.FromBundle("ProfileImageBig");
                    }
                    else
                    {
                        var data = NSData.FromArray(Miembro.Usuario_Fotografia_Perfil);
                        var uiimage = UIImage.LoadFromData(data);
                        ReescalImageUsr = ImageHelper.ReescalProfileImage(uiimage);
                    }

                }
                else
                {
                    ReescalImageUsr = UIImage.FromBundle("ProfileImageBig");
                }

               
                if (Miembro.Usuario_Fotografia_Fondo != null && Miembro.Usuario_Fotografia_Fondo != "")
                {
                    if (Miembro.Usuario_Fotografia_FondoPerfil == null)
                    {

                        Miembro.Usuario_Fotografia_FondoPerfil = new UploadImages().DownloadFileFTP(Miembro.Usuario_Fotografia_Fondo, MenuHelper.ProfileImagePath);

                    }
                    if (Miembro.Usuario_Fotografia_FondoPerfil.Length != 0)
                    {
                        var data = NSData.FromArray(Miembro.Usuario_Fotografia_FondoPerfil);
                        var uiimage = UIImage.LoadFromData(data);
                        ReescalImageBack = ImageHelper.ReescalProfileImage(uiimage);
                    }

                }

            });
            this.btnProfileImage.SetBackgroundImage(ReescalImageUsr, UIControlState.Normal);
            this.btnImageBackGround.SetBackgroundImage(ReescalImageBack, UIControlState.Normal);
        }

        partial void btnEditarPerfil_Touch(UIButton sender)
        {
            this.PerformSegue("EditarPerfil", null);
        }

        partial void btnCerrar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnSeguir_Touch(UIButton sender)
        {
            this.AsignarFavorito();
        }

        private void AsignarFavorito()
        {
            if (isFavorite.Value)
            {
                result = new UsuariosController().RemoveMiembroFavorito(isFavorite);
                if (result)
                {
                    this.btnSeguir.SetTitle("+SEGUIR", UIControlState.Normal);
                }
            }
            else
            {
                result = new UsuariosController().AddMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Miembro.Usuario_Id, Miembro.Usuario_Tipo);
                if (result)
                {
                    this.btnSeguir.SetTitle("-DEJAR DE SEGUIR", UIControlState.Normal);
                }
            }
        }

        private async Task PreguntarFavorito()
        {
            await Task.Run(() =>
            {
                var Favorito = new UsuariosController();
                isFavorite = Favorito.IsMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Miembro.Usuario_Id, Miembro.Usuario_Tipo);
            });
            if (isFavorite.Value)
            {
                this.btnSeguir.SetTitle("-DEJAR DE SEGUIR", UIControlState.Normal);
            }
            else
            {
                this.btnSeguir.SetTitle("+SEGUIR", UIControlState.Normal);
            }
        }

        partial void btnEnviarMensaje_Touch(UIButton sender)
        {
            this.LaunchApp("mx.worklabs.uc://");
        }

        public Task<bool> LaunchApp(string uri)
        {
            var canOpen = UIApplication.SharedApplication.CanOpenUrl(new NSUrl(uri));

            return Task.FromResult(UIApplication.SharedApplication.OpenUrl(new NSUrl(uri)));
        }
    }

    public partial class PerfilesTableViewController : EventosEditarPerfil
    {
        public void MiInfo(UsuarioModel InfoActualizar)
        {
            this.Miembro = InfoActualizar;

            new MessageDialog().SendToast("Información actualizada con éxito");
            this.PerfilesDelegate.InfoActualizar();
            this.DismissViewController(true, null);
        }
    }

}