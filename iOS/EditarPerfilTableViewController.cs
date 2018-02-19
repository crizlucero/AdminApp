using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using Foundation;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using System.Globalization;

namespace WorklabsMx.iOS
{
    public partial class EditarPerfilTableViewController : UITableViewController
    {
        UIImagePickerController imgPicker;

        bool TouchedBack = false, TouchedProfile = false;

        bool FromMi = true, FromSocial = false, FromTrabajo = false;

        public UsuarioModel InfoPerifl;

        public UsuarioModel NewInfoPerfil = new UsuarioModel();

        public EditarPerfilTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            imgPicker = new UIImagePickerController();
            imgPicker.Delegate = this;
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
            UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
            if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
            {
                statusBar.BackgroundColor = UIColor.Black;
            }
            UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;

            this.txtNombre.AttributedPlaceholder = new NSAttributedString("  Nombre", null, UIColor.Clear.FromHex(0x767676));
            txtNombre.Text = InfoPerifl.Usuario_Nombre;// + " " + InfoPerifl.Usuario_Apellidos;

            this.txtApellidos.AttributedPlaceholder = new NSAttributedString("  Nombre", null, UIColor.Clear.FromHex(0x767676));
            txtApellidos.Text = InfoPerifl.Usuario_Apellidos;

            lblEmpresa.Text = (InfoPerifl.Usuario_Empresa_Nombre != "" && InfoPerifl.Usuario_Empresa_Nombre != null) ? InfoPerifl.Usuario_Empresa_Nombre : "Sin Info";
            NewInfoPerfil.Usuario_Empresa_Nombre = lblEmpresa.Text;
            btnImagen.SetBackgroundImage(ImageGallery.LoadImage(InfoPerifl.Usuario_Fotografia) ?? UIImage.FromBundle("ProfileImageBig"), UIControlState.Normal);
            this.vwVistaMi.Hidden = false;
            this.vwSocial.Hidden = true;
            this.vwTrabajo.Hidden = true;
        }

        partial void FondoImagen_Touch(UIButton sender)
        {
            TouchedBack = true;
            PresentViewController(CrearActionSheet(), true, null);
        }

        partial void btnImagen_Touch(UIButton sender)
        {
            TouchedProfile = true;
            PresentViewController(CrearActionSheet(), true, null);
        }


        partial void btnClose_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }


        private UIAlertController CrearActionSheet()
        {
            var ShowGalleryAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);

            ShowGalleryAlert.AddAction(this.AbrirGaleria(this.imgPicker));
            ShowGalleryAlert.AddAction(this.AbrirCamara(this.imgPicker));

            var CloseAction = UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel,(action) =>
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
                this.btnFondoImagen.SetBackgroundImage(image, UIControlState.Normal);
            }
            else if (this.TouchedProfile)
            {
                this.btnImagen.SetBackgroundImage(image, UIControlState.Normal);
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
                            SlackLogs.SendMessage(e.Message);
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

        partial void btnSocial_Touch(UIButton sender)
        {
            this.vwVistaMi.Hidden = true;
            this.vwSocial.Hidden = false;
            this.vwTrabajo.Hidden = true;
            this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromMi)
            {
                this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
                this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwVistaMi.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
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

        partial void btnSobreMi_Touch(UIButton sender)
        {
            this.vwVistaMi.Hidden = false;
            this.vwSocial.Hidden = true;
            this.vwTrabajo.Hidden = true;
            this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwVistaMi.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
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

        partial void btnTrabajo_Touch(UIButton sender)
        {
            this.vwVistaMi.Hidden = true;
            this.vwSocial.Hidden = true;
            this.vwTrabajo.Hidden = false;
            this.btnTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnTrabajo.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromMi)
            {
                this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwVistaMi.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            else if (FromSocial)
            {
                this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            this.FromMi = false;
            this.FromSocial = false;
            this.FromTrabajo = true;
        }

        partial void btnGuardar_Touch(UIButton sender)
        {
            NewInfoPerfil.Usuario_Nombre = txtNombre.Text;
            NewInfoPerfil.Usuario_Apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = new DateTime();
            fechaNacimiento = DateTime.ParseExact(NewInfoPerfil.Usuario_Fecha_Nacimiento, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            if (new UsuariosController().UpdateDataMiembros(int.Parse(KeyChainHelper.GetKey("Usuario_Id")), NewInfoPerfil.Usuario_Nombre, NewInfoPerfil.Usuario_Apellidos, NewInfoPerfil.Usuario_Correo_Electronico, 
                                                            NewInfoPerfil.Usuario_Telefono, NewInfoPerfil.Usuario_Celular ,NewInfoPerfil.Usuario_Profesion, NewInfoPerfil.Usuario_Puesto, "", fechaNacimiento, ""))
            {
                
            }
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "EditarMiInfo")
            {
                var VistaHabilidades = (EditarMiInfoPerfilViewController)segue.DestinationViewController;
                VistaHabilidades.EditarInfoDelegate = this;
                VistaHabilidades.Miembro = InfoPerifl;
            }
            else if (segue.Identifier == "EditarSociales")
            {
                var VistaRedesSociales = (VistaEditarRedesSociales)segue.DestinationViewController;
                VistaRedesSociales.Redes_Sociales = InfoPerifl.Redes_Sociales;
                VistaRedesSociales.Miembro = InfoPerifl;
                VistaRedesSociales.VistaRedesSocialesDelegate = this;
            }
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }
    }

    public partial class EditarPerfilTableViewController : EventosActualizarInfoPerfil
    {
        public void InfoSobreMi(UsuarioModel InfoActualizar)
        {
            NewInfoPerfil = InfoActualizar;
        }
    }

    public partial class EditarPerfilTableViewController : EventosVistaRedesSociales
    {
        public void RedesSociales(List<RedSocialModel> Redes_Sociales)
        {
            
        }
    }
}