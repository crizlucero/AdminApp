using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using AVFoundation;
using Photos;
using WorklabsMx.Helpers;

namespace WorklabsMx.iOS
{
    public partial class PerfilTableViewController : UITableViewController
    {
        MiembroModel Miembro;
        MiembroModel MiembroClon;
        UIImage ImagenPublicacion;

        UIImagePickerController imgPicker;
        string UrlImage = "";

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.imgPerfil.Layer.MasksToBounds = true;
            this.imgPerfil.Layer.CornerRadius = this.imgPerfil.Layer.Bounds.Size.Width / 2;
            StyleHelper.Style(this.imgPerfil.Layer);
            StyleHelper.Style(this.btnEditarFecha.Layer);
            StyleHelper.Style(this.btnEditarGenero.Layer);
            StyleHelper.Style(this.btnGuardarCambios.Layer);
            imgPicker = new UIImagePickerController();
            imgPicker.Delegate = this;
            //this.btnGuardarCambios.Enabled = false;
            if (InternetConectionHelper.VerificarConexion())
            {
                var StoregeLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
                Miembro = new MiembrosController().GetMemberData(StoregeLocal.Get("Usuario_Id"), StoregeLocal.Get("Usuario_Tipo"));
                MiembroClon = new MiembrosController().GetMemberData(StoregeLocal.Get("Usuario_Id"), StoregeLocal.Get("Usuario_Tipo"));
                this.txtEmail.Text = Miembro.Miembro_Correo_Electronico;
                this.txtNombre.Text = Miembro.Miembro_Nombre;
                this.txtApellido.Text = Miembro.Miembro_Apellidos;
                this.txtTelefono.Text = Miembro.Miembro_Telefono;
                this.txtProfesion.Text = Miembro.Miembro_Profesion;
                this.txtHabilidades.Text = Miembro.Miembro_Habilidades;
            }
            else
            {
                new MessageDialog().SendToast("No tienes conexión a internet, intenta mas tarde");
            }

        }

        public PerfilTableViewController (IntPtr handle) : base (handle)
        {
        }

        partial void btnFoto_TpuchUpInside(UIButton sender)
        {
            this.PresentViewController(CrearActionSheet(), true, null);
        }

        partial void btnEditarFecha_TouchUpInside(UIButton sender)
        {
            
        }

        partial void btnEditarGenero_TouchUpInside(UIButton sender)
        {
            
        }

        private UIAlertController CrearActionSheet()
        {
            var ShowGalleryAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);

            ShowGalleryAlert.AddAction(this.AbrirGaleria(this.imgPicker));
            ShowGalleryAlert.AddAction(this.AbrirCamara(this.imgPicker));

            var CloseAction = UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, null);
            ShowGalleryAlert.AddAction(CloseAction);
            return ShowGalleryAlert;

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

        [Foundation.Export("imagePickerController:didFinishPickingImage:editingInfo:")]
        public void FinishedPickingImage(UIKit.UIImagePickerController picker, UIKit.UIImage image, Foundation.NSDictionary editingInfo)
        {
            ImagenPublicacion = image;
            var imageUrl = editingInfo["UIImagePickerControllerReferenceURL"] as NSUrl;
            UrlImage = imageUrl.RelativeString;
            this.imgPerfil.Image = image;

            picker.DismissViewController(true, null);
        }

        [Foundation.Export("imagePickerControllerDidCancel:")]
        public void Canceled(UIKit.UIImagePickerController picker)
        {
            picker.DismissViewController(true, null);
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

        private UIImagePickerController SelectImage(UIImagePickerController ImagePicker)
        {
            ImagePicker.AllowsEditing = false;
            ImagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            ImagePicker.AllowsEditing = true;
            return ImagePicker;
        }

        partial void btnGuardarCambios_TouchUpInside(UIButton sender)
        {
            if (InternetConectionHelper.VerificarConexion())
            {
                /*if (new MiembrosController().UpdateDataMiembros(Convert.ToInt32(StoregeLocal.Get("Usuario_Id")), txtNombre.Text, txtApellido.Text, txtEmail.Text,
                                                                   txtTelefono.Text, txtTelefono.Text, txtProfesion.Text, txtProfesion.Text, txtHabilidades.Text, (DateTime)dpFechaNacimiento.Date, ""))
                    new MessageDialog().SendToast("Datos guardados");
                else
                    new MessageDialog().SendToast("Hubo un error\nIntente de nuevo");*/
            }
            else
            {
                new MessageDialog().SendToast("Error de conexión, intente de nuevo");
            }

        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if(segue.Identifier == "toSelectGender")
            {
                var postCommentView = (GeneroViewController)segue.DestinationViewController;
                postCommentView.GeneroSeleccionadoDelegato = this;
            } 
        }


    }


    partial class PerfilTableViewController : GeneroSeleccionado
    {

        public void GeneroSeleccionado(string Genero)
        {
            this.lblGenero.Text = Genero;
        }

    }
}