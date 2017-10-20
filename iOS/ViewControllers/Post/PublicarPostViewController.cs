using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;
using System.Collections.Generic;
using WorklabsMx.Enum;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;
using BigTed;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{

    public interface PostPublicadoDel
    {
        void PostPublicado();
    }

    public partial class PublicarPostViewController : UIViewController
    {
        
        SimpleStorage storageLocal;
        DateTime FechaActual;
        string Nombre;
        string Ocupacion;
        string ImagenPerfil;
        float opacity = 0.5f;

        UIImagePickerController imgPicker;

        UIImage ImagenPublicacion;

        public PostPublicadoDel PostPublicadoDelegate;

        public PublicarPostViewController(IntPtr handle) : base(handle)
        {
            storageLocal = SimpleStorage.EditGroup("Login");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            imgPicker = new UIImagePickerController();
            imgPicker.Delegate = this;
        }

        public void setInfoPublicacion(List<string> miembro)
        {
            this.ImagenPerfil = miembro[(int)CamposMiembro.Usuario_Fotografia];
            this.Nombre = miembro[(int)CamposMiembro.Usuario_Nombre];
            this.Ocupacion = miembro[(int)CamposMiembro.Usuario_Puesto];
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.lblNombre.Text = Nombre;
            this.lblOcupacion.Text = Ocupacion;
            var color = new UIColor(1, 0.8f);
            this.View.BackgroundColor = color;
            StyleHelper.Style(btnPublicar.Layer);
            StyleHelper.Style(vwVistaComentar.Layer);
            this.btnPublicar.Layer.Opacity = opacity;
            this.txtPublicacion.Changed += HandleTextMessageChanged;
            FechaActual = DateTime.Now;
            lblFechaPublicacion.Text = String.Format("{0:dddd, d MMMM, yyyy}", FechaActual);
            imgPerfil.Image = ImageGallery.LoadImage(this.ImagenPerfil);
        }


        private async void PublicarPost()
        {
            BTProgressHUD.Show();
            await Task.Delay(500);
            NSUuid id;

            byte[] Fotografia;
            string NombreFoto;

            if (ImagenPublicacion != null )
            {
                Fotografia = ImagenPublicacion?.AsPNG().ToArray();
                id = new NSUuid();
                NombreFoto = id.ToString();
            }
            else 
            {
                Fotografia = null;
                id = null;
                NombreFoto = "";
            }

            if (new Controllers.EscritorioController().SetPost(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"), txtPublicacion.Text, NombreFoto, Fotografia))
            {
                this.PostPublicadoDelegate?.PostPublicado();
                this.DismissViewController(true, null);
            }
            else
            {
                BTProgressHUD.Dismiss();
                new MessageDialog().SendToast("No se pudo publicar el post");
            }
        }

        partial void btnPublicar_TouchUpInside(UIButton sender)
        {
            this.PublicarPost();
        }

        partial void btnClose_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            var touch = touches.AnyObject as UITouch;

            var location = touch.LocationInView(this.View);
            if (this.vwVistaComentar.Frame.Contains(location) == false)
            {
                this.DismissViewController(true, null);
            }
        }

        private void HandleTextMessageChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPublicacion.Text))
            {
                this.btnPublicar.Enabled = false;
                this.btnPublicar.Layer.Opacity = 0.5f;
            }
            else 
            {
                this.btnPublicar.Enabled = true;
                this.btnPublicar.Layer.Opacity = 1f;
            }
        }

        partial void btnGaleria_TouchUpInside(UIButton sender)
        {
            PresentViewController(CrearActionSheet(), true, null);
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

        [Foundation.Export("imagePickerController:didFinishPickingImage:editingInfo:")]
        public void FinishedPickingImage(UIKit.UIImagePickerController picker, UIKit.UIImage image, Foundation.NSDictionary editingInfo)
        {
            ImagenPublicacion = image;
            this.btnImageComment.SetImage(image, UIControlState.Normal);
            this.btnDeleteImge.Hidden = false;
            this.btnPublicar.Enabled = true;
            opacity = 1f;
            this.btnImageComment.ContentMode = UIViewContentMode.ScaleAspectFit;
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

            UIAlertAction openCamera = UIAlertAction.Create("Tomar fotografia", UIAlertActionStyle.Default,  ( action ) =>
            {
                AVCaptureDevice.RequestAccessForMediaType(AVMediaType.Video, ( bool isAccessGranted) => 
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

        partial void btnImageComment_TouchUpInside(UIButton sender)
        {
            this.PerformSegue("toViewImage", null);
        }

        partial void btnDeleteImage_TouchUpInside(UIButton sender)
        {
            this.btnImageComment.SetImage(null, UIControlState.Normal);
            if (this.txtPublicacion.Text == "")
            {
                this.btnPublicar.Layer.Opacity = 0.5f;
                this.btnPublicar.Enabled = false;
            }
            this.btnDeleteImge.Hidden = true;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "toViewImage")
            {
                var postCommentView = (DetailCommentImage)segue.DestinationViewController;
                postCommentView.ImagenPost = this.btnImageComment.ImageView;
            }

        }
    }



}