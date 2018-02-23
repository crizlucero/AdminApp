using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Enum;


namespace WorklabsMx.iOS
{

    public interface EventosVistaTrabajo
    {
        void InfoEmpresa(UsuarioModel Empresa);
    }

    public partial class TrabajoViewController : UIViewController
    {

        UIImagePickerController imgPicker;

        public UsuarioModel InfoPerifl;

        public EventosVistaTrabajo EventosVistaTrabajoDelegate;

        public TrabajoViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            txtCiudad.EditingChanged += (sender, e) =>
            {
                InfoPerifl.Empresa_Actual.Territorio.Municipio = txtCiudad.Text;
                EventosVistaTrabajoDelegate.InfoEmpresa(InfoPerifl);
            };

            txtPuesto.EditingChanged += (sender, e) =>
            {
                InfoPerifl.Usuario_Puesto = txtPuesto.Text;
                EventosVistaTrabajoDelegate.InfoEmpresa(InfoPerifl);
            };

            txtCompañia.EditingChanged += (sender, e) =>
            {
                InfoPerifl.Empresa_Actual.Empresa_Nombre = txtCompañia.Text;
                EventosVistaTrabajoDelegate.InfoEmpresa(InfoPerifl);
            };

            imgPicker = new UIImagePickerController();
            imgPicker.Delegate = this;

            StyleHelper.Style(this.vwAño.Layer);
            StyleHelper.Style(this.vwMes.Layer);
            StyleHelper.Style(this.vwPais.Layer);
            StyleHelper.Style(this.vwCiudad.Layer);
            StyleHelper.Style(this.vwPuesto.Layer);
            StyleHelper.Style(this.vwWebSite.Layer);
            StyleHelper.Style(this.vwCompañia.Layer);

            imgPais.UserInteractionEnabled = true;
            UITapGestureRecognizer tapGestureImgPais = new UITapGestureRecognizer(imgPaisTouch);

            this.imgPais.AddGestureRecognizer(tapGestureImgPais);

            if(InfoPerifl != null)
            {
                if (InfoPerifl.Empresa_Actual != null)
                {
                    if (InfoPerifl.Empresa_Actual.Territorio != null)
                    {
                        this.txtCiudad.Text = InfoPerifl.Empresa_Actual.Territorio.Municipio;
                        this.lblPais.Text = InfoPerifl.Empresa_Actual.Territorio.Pais;
                    }
                    this.txtWebSite.Text = InfoPerifl.Empresa_Actual.Empresa_Pagina_Web;
                    this.txtCompañia.Text = InfoPerifl.Empresa_Actual.Empresa_Nombre;
                }
                if (InfoPerifl != null)
                {
                    this.txtPuesto.Text = InfoPerifl.Usuario_Puesto;
                }
            }
           

        }

        partial void btnSeleccionarImagen_Touch(UIButton sender)
        {
            PresentViewController(CrearActionSheet(), true, null);
        }

        private void imgPaisTouch(UITapGestureRecognizer Recognizer)
        {
            this.PerformSegue("Pais", null);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if(segue.Identifier == "Pais")
            {
                var VistaPaises = (PaisesViewController)segue.DestinationViewController;
                VistaPaises.PaisDelegate = this;
            }
        }


        [Foundation.Export("imagePickerController:didFinishPickingImage:editingInfo:")]
        public void FinishedPickingImage(UIKit.UIImagePickerController picker, UIKit.UIImage image, Foundation.NSDictionary editingInfo)
        {
            this.btnSeleccionarImagen.SetBackgroundImage(image, UIControlState.Normal);
            picker.DismissViewController(true, null);
        }

        private UIAlertController CrearActionSheet()
        {
            var ShowGalleryAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);

            ShowGalleryAlert.AddAction(this.AbrirGaleria(this.imgPicker));
            ShowGalleryAlert.AddAction(this.AbrirCamara(this.imgPicker));

            var CloseAction = UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, (action) =>
            {
            });
            ShowGalleryAlert.AddAction(CloseAction);
            return ShowGalleryAlert;

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
    }



    public partial class TrabajoViewController : Pais
    {
        public void PaisSeleccionado(string Pais)
        {
            this.lblPais.Text = Pais;
            InfoPerifl.Empresa_Actual.Territorio.Pais = this.lblPais.Text;
            EventosVistaTrabajoDelegate.InfoEmpresa(InfoPerifl);
        }
    }
}