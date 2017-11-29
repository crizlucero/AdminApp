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
using System.Globalization;

namespace WorklabsMx.iOS
{
    public partial class DatosEmpresaTableViewController : UITableViewController
    {

        SimpleStorage StoregeLocal;

        UIImage ImagenPublicacion;

        UIImagePickerController imgPicker;
        string UrlImage = "";

        EmpresaModel Empresa;

        PickerItemsController items;

        string GiroId;

        public DatosEmpresaTableViewController (IntPtr handle) : base (handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
            items = new PickerItemsController();
            StoregeLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            StyleHelper.Style(this.imgPerfil.Layer);
            StyleHelper.Style(this.btnEditarDireccion.Layer);
            StyleHelper.Style(this.btnActualizarEmpresa.Layer);
            StyleHelper.Style(this.btnEditarRedesSociales.Layer);
            if(InternetConectionHelper.VerificarConexion())
            {
                Empresa = new EmpresaController().GetEmpresaMiembro(StoregeLocal.Get("Usuario_Id"));
                this.txtRFC.Text = Empresa.Empresa_Miembro_Rfc;
                this.txtTelefono.Text = Empresa.Empresa_Miembro_Telefono;
                this.txtRazonSocial.Text = Empresa.Empresa_Miembro_Razon_Social;
                this.txtGiroComercial.Text = Empresa.Giro_Descripcion;
                GiroId = items.GetGiroId(txtGiroComercial.Text).ToString();
                this.txtNombreEmpresa.Text = Empresa.Empresa_Miembro_Nombre;
                this.txtCorreoElectronico.Text = Empresa.Empresa_Miembro_Correo_Electronico;
            }
            else 
            {
                new MessageDialog().SendToast("No tienes conexión a internet, intenta mas tarde");
                this.NavigationController.PopViewController(true);
            }

        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }

        partial void btnEditarDireccion_TouchUpInside(UIButton sender)
        {
            
        }

        partial void btnRedesSociales_TouchUpInside(UIButton sender)
        {
            
        }

        partial void btnActualizar_TouchUpInside(UIButton sender)
        {
            if (new EmpresaController().UpdateDataEmpresa(Empresa.Empresa_Miembro_Id, StoregeLocal.Get("Usuario_Id"), GiroId, "", txtRazonSocial.Text, txtRFC.Text,
                                                              txtNombreEmpresa.Text, Empresa.Empresa_Miembro_Calle, Empresa.Empresa_Miembro_Numero_Exterior, Empresa.Empresa_Miembro_Numero_Interior, txtCorreoElectronico.Text, txtTelefono.Text, Empresa.Empresa_Miembro_Pagina_Web, Empresa.Empresa_Miembro_Red_Social_1, Empresa.Empresa_Miembro_Red_Social_2,Empresa.Empresa_Miembro_Red_Social_3, Empresa.Empresa_Miembro_Logotipo))
                new MessageDialog().SendToast("Datos guardados");
            else
                new MessageDialog().SendToast("Hubo un error\nIntente de nuevo");
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
            StyleHelper.Style(this.imgPerfil.Layer);
            this.imgPerfil.Image = image;
            this.imgPerfil.Layer.MasksToBounds = true;
            this.imgPerfil.Layer.CornerRadius = this.imgPerfil.Layer.Bounds.Size.Width / 2;

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

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
           
        }
    }
}