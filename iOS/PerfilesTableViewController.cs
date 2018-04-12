using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using WorklabsMx.Helpers;
using System.Collections.Generic;
using Foundation;
using System.Threading.Tasks;
using Photos;
using AVFoundation;

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

        UIImagePickerController imgPicker;

        bool TouchedBack = false, TouchedProfile = false;

        public PerfilesTableViewController (IntPtr handle) : base (handle)
        {
            //this.Miembro = MenuHelper.Usuario;
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            imgPicker = new UIImagePickerController();
            imgPicker.Delegate = this;
            await PreguntarFavorito();
            if (InfoPersonal)
            {
                this.btnSeguir.Hidden = true;
                this.btnEnviarMensaje.Hidden = true;
                this.btnEditarPerfil.Hidden = false;
                this.btnEditarFoto.Hidden = false;
                this.btnEditarFotoFondo.Hidden = false;

                this.btnSeguir.Enabled = false;
                this.btnEnviarMensaje.Enabled = false;
                this.btnEditarPerfil.Enabled = true;
                this.btnEditarFoto.Enabled = true;
                this.btnEditarFotoFondo.Enabled = true;
            }
            else
            {
                this.btnSeguir.Hidden = false;
                this.btnEnviarMensaje.Hidden = false;
                this.btnEditarPerfil.Hidden = true;
                this.btnEditarFoto.Hidden = true;
                this.btnEditarFotoFondo.Hidden = true;

                this.btnSeguir.Enabled = true;
                this.btnEnviarMensaje.Enabled = true;
                this.btnEditarPerfil.Enabled = false;
                this.btnEditarFoto.Enabled = false;
                this.btnEditarFotoFondo.Enabled = false;
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

        async Task GetImages(UsuarioModel MiembroLocal)
        {
            UIImage ReescalImageBack = new UIImage();
            UIImage ReescalImageUsr = new UIImage();
            await Task.Run(() =>
            {
                
                if ((MiembroLocal.Usuario_Fotografia != "" && MiembroLocal.Usuario_Fotografia != null  && MiembroLocal.Usuario_Fotografia != "user_male.png"))
                {
                    if (MiembroLocal.Usuario_Fotografia_Perfil == null)
                    {
                        MiembroLocal.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(MiembroLocal.Usuario_Fotografia, MenuHelper.ProfileImagePath);
                    }
                    if (MiembroLocal.Usuario_Fotografia_Perfil.Length == 0)
                    {
                        ReescalImageUsr = UIImage.FromBundle("ProfileImageBig");
                    }
                    else
                    {
                        var data = NSData.FromArray(MiembroLocal.Usuario_Fotografia_Perfil);
                        var uiimage = UIImage.LoadFromData(data);
                        ReescalImageUsr = ImageHelper.ReescalProfileImage(uiimage);
                    }

                }
                else
                {
                    ReescalImageUsr = UIImage.FromBundle("ProfileImageBig");
                }

               
                if (MiembroLocal.Usuario_Fotografia_Fondo != null && MiembroLocal.Usuario_Fotografia_Fondo != "")
                {
                    if (MiembroLocal.Usuario_Fotografia_FondoPerfil == null)
                    {

                        MiembroLocal.Usuario_Fotografia_FondoPerfil = new UploadImages().DownloadFileFTP(MiembroLocal.Usuario_Fotografia_Fondo, MenuHelper.ProfileImagePath);

                    }
                    if (MiembroLocal.Usuario_Fotografia_FondoPerfil.Length > 0)
                    {
                        var data = NSData.FromArray(MiembroLocal.Usuario_Fotografia_FondoPerfil);
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
            if (InfoPersonal)
            {
                this.PerfilesDelegate.InfoActualizar();
            }
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
            this.LaunchApp();
        }

        public void LaunchApp()
        {
            try
            {
                var canOpen = UIApplication.SharedApplication.CanOpenUrl(NSUrl.FromString("testscheme://mx.worklabs.uc"));
                if (canOpen)
                {
                    UIApplication.SharedApplication.OpenUrl(NSUrl.FromString("testscheme://mx.worklabs.uc"));
                }
                UIApplication.SharedApplication.OpenUrl(NSUrl.FromString("itms://itunes.apple.com/mx/app/worklabs-uc/id1343248277?mt=8"));
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "Abri WorkLabs UC");
            }
           
        }

        partial void btnEditarFotoFondo_Touch(UIButton sender)
        {
            TouchedBack = true;
            PresentViewController(CrearActionSheet(), true, null);
        }

        partial void btnEditarFotoPerfil_Touch(UIButton sender)
        {
            TouchedProfile = true;
            PresentViewController(CrearActionSheet(), true, null);
        }


        private UIAlertController CrearActionSheet()
        {
            var ShowGalleryAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);

            ShowGalleryAlert.AddAction(this.AbrirGaleria(this.imgPicker));
            ShowGalleryAlert.AddAction(this.AbrirCamara(this.imgPicker));

            var CloseAction = UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, (action) =>
            {
                this.TouchedBack = false;
                this.TouchedProfile = false;
            });
            ShowGalleryAlert.AddAction(CloseAction);
            return ShowGalleryAlert;

        }

        [Foundation.Export("imagePickerController:didFinishPickingImage:editingInfo:")]
        public void FinishedPickingImage(UIKit.UIImagePickerController picker, UIKit.UIImage image, Foundation.NSDictionary editingInfo)
        {
            if (this.TouchedBack)
            {

                image = ImageHelper.ReescalProfileBackImage(image);
                this.btnImageBackGround.SetBackgroundImage(image, UIControlState.Normal);
                Miembro.Usuario_Fotografia_FondoPerfil = image?.AsPNG().ToArray();
                this.GuardarInfo();
            }
            else if (this.TouchedProfile)
            {
                image = ImageHelper.ReescalProfileImage(image);
                this.btnProfileImage.SetBackgroundImage(image, UIControlState.Normal);
                Miembro.Usuario_Fotografia_Perfil = image?.AsPNG().ToArray();
                this.GuardarInfo();
            }
            this.TouchedBack = false;
            this.TouchedProfile = false;
            picker.DismissViewController(true, null);
        }

        [Foundation.Export("imagePickerControllerDidCancel:")]
        public void Canceled(UIKit.UIImagePickerController picker)
        {
            picker.DismissViewController(true, null);
        }

        private UIImagePickerController SelectImage(UIImagePickerController ImagePicker)
        {
            ImagePicker.AllowsEditing = false;
            ImagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            ImagePicker.AllowsEditing = true;
            return ImagePicker;
        }

        private UIAlertAction AbrirCamara(UIImagePickerController ImagePicker)
        {
            const String HeaderMessage = "Se necesita acceso a la camara";
            const String BodyMessage = "Habilita el acceso de Worklabs a la camara en la configuración de tu iPhone";

            UIAlertAction openCamera = UIAlertAction.Create("Tomar fotografia", UIAlertActionStyle.Default, (action) =>
            {
                AVCaptureDevice.RequestAccessForMediaType(AVMediaType.Video, (bool isAccessGranted) =>
                {
                    InvokeOnMainThread(() =>
                    {
                        try
                        {
                            if (isAccessGranted)
                            {
                                ImagePicker.SourceType = UIImagePickerControllerSourceType.Camera;
                                ImagePicker.CameraDevice = UIImagePickerControllerCameraDevice.Rear;
                                ImagePicker.AllowsEditing = true;
                                this.PresentViewController(ImagePicker, true, null);
                            }
                            else
                            {
                                this.PresentViewController(this.PermisosDispositivo(HeaderMessage, BodyMessage), true, null);
                            }
                        }
                        catch (Exception e)
                        {
                            SlackLogs.SendMessage(e.Message, "", "AbrirCamara");
                        }

                    });
                });

            });

            return openCamera;
        }



        private UIAlertAction AbrirGaleria(UIImagePickerController ImagePicker)
        {
            const String HeaderMessage = "Se necesita acceso a la galería";
            const String BodyMessage = "Habilita el acceso de Worklabs a la galería en la configuración de tu iPhone";
            UIAlertAction openGalery = UIAlertAction.Create("Selecciona una foto", UIAlertActionStyle.Default, (action) =>
            {
                var photos = PHPhotoLibrary.AuthorizationStatus;
                if (photos != PHAuthorizationStatus.NotDetermined)
                {
                    this.PresentViewController(this.SelectImage(ImagePicker), true, null);
                }
                else
                {
                    PHPhotoLibrary.RequestAuthorization(handler: (obj) =>
                    {
                        InvokeOnMainThread(() =>
                        {
                            if (obj != PHAuthorizationStatus.Authorized)
                            {
                                this.PresentViewController(this.PermisosDispositivo(HeaderMessage, BodyMessage), true, null);
                            }
                            else
                            {
                                this.PresentViewController(this.SelectImage(ImagePicker), true, null);
                            }
                        });
                    });
                }
            });
            return openGalery;
        }

        private UIAlertController PermisosDispositivo(String headerMessage, String BodyMessage)
        {
            var alert = UIAlertController.Create(headerMessage, BodyMessage, UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Aceptar", UIAlertActionStyle.Default, (Action) =>
            {
                this.openSettings();
            }));
            alert.AddAction(UIAlertAction.Create("Cancelar", UIAlertActionStyle.Default, null));
            return alert;
        }

        private void openSettings()
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
        }

        private void GuardarInfo()
        {
            bool resultDataMiembros = false;
            DateTime fechaNacimiento = new DateTime();
            fechaNacimiento = DateTime.Parse(Miembro.Usuario_Fecha_Nacimiento);
            resultDataMiembros = new UsuariosController().UpdateDataMiembros(KeyChainHelper.GetKey("Usuario_Id"), Miembro.Usuario_Nombre, Miembro.Usuario_Apellidos, Miembro.Usuario_Correo_Electronico,
                                                                             Miembro.Usuario_Telefono, Miembro.Usuario_Celular, Miembro.Usuario_Descripcion, fechaNacimiento, Miembro.Usuario_Fotografia_Perfil, Miembro.Usuario_Fotografia_FondoPerfil);
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