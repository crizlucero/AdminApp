using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using System.Collections.Generic;
using WorklabsMx.Enum;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;
using BigTed;
using System.Threading.Tasks;
using UserNotifications;

namespace WorklabsMx.iOS
{

    public interface PostPublicadoDel
    {
        void PostPublicado();
    }

    public partial class PublicarPostViewController : UIViewController
    {
        
        DateTime FechaActual;

        UIImagePickerController imgPicker;

        UIImage ImagenPublicacion;

        public PostPublicadoDel PostPublicadoDelegate;

        public PublicarPostViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            imgPicker = new UIImagePickerController();
            imgPicker.Delegate = this;
        }

        public override void ViewWillAppear(bool animated)
        {
            var Usuario = MenuHelper.Usuario;
            base.ViewWillAppear(animated);
            this.lblNombre.Text = Usuario.Usuario_Nombre;
            this.lblOcupacion.Text = Usuario.Usuario_Puesto;
            if (Usuario.Usuario_Fotografia_Perfil != null)
            {
                var data = NSData.FromArray(Usuario.Usuario_Fotografia_Perfil);
                imgPerfil.Image = UIImage.LoadFromData(data);
            }
            else
            {
                imgPerfil.Image = UIImage.FromBundle("ProfileImageBig");
            }
            var color = new UIColor(0, 0.55f);
            this.View.BackgroundColor = color;
            StyleHelper.Style(btnPublicar.Layer);
            StyleHelper.Style(vwVistaComentar.Layer);
            this.txtPublicacion.Changed += HandleTextMessageChanged;
            FechaActual = DateTime.Now;
            lblFechaPublicacion.Text = String.Format("{0:dddd, d MMMM, yyyy}", FechaActual);
        }


        private void PublicarPost()
        {
            BTProgressHUD.Show();

            byte[] Fotografia;
            if (ImagenPublicacion != null)
            {
                Fotografia = ImagenPublicacion?.AsPNG().ToArray();
            }
            else
            {
                Fotografia = new byte[0];
            }

            if (InternetConectionHelper.VerificarConexion())
            {
                if (new Controllers.EscritorioController().SetPost(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), txtPublicacion.Text, Fotografia))
                {
                    this.PostPublicadoDelegate.PostPublicado();
                    this.SendMessage();
                    this.DismissViewController(true, null);
                    BTProgressHUD.Dismiss();
                }
                else
                {
                    BTProgressHUD.Dismiss();
                    new MessageDialog().SendToast("No pudimos publicar tu mensaje, intenta de nuevo");
                }
            }
            else
            {
                BTProgressHUD.Dismiss();
                new MessageDialog().SendToast("No tienes conexión a internet, intenta de nuevo");
            }

        }

        public void SendMessage()
        {
            var content = new UNMutableNotificationContent();
            content.Title = "Notification Title";
            content.Subtitle = "Notification Subtitle";
            content.Body = "This is the message body of the notification.";
            content.Badge = 1;

            var trigger = UNTimeIntervalNotificationTrigger.CreateTrigger(5, false);

            var requestID = "sampleRequest";
            var request = UNNotificationRequest.FromIdentifier(requestID, content, trigger);
            UNUserNotificationCenter.Current.AddNotificationRequest(request, (err) => {
                if (err != null)
                {
                    // Do something with error...
                }
            });
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
            this.txtPublicacion.ResignFirstResponder();
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
            ImagenPublicacion = ImageHelper.ReescalImage(image);
            this.btnImageComment.SetImage(image, UIControlState.Normal);
            this.btnDeleteImge.Hidden = false;
            this.btnPublicar.Enabled = true;
            this.btnImageComment.ContentMode = UIViewContentMode.ScaleAspectFit;
            this.btnImageComment.Enabled = true;
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

        partial void btnImageComment_TouchUpInside(UIButton sender)
        {
            if (this.btnImageComment.Enabled)
            {
                this.PerformSegue("toViewImage", null);
            }

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
            this.btnImageComment.Enabled = false;
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