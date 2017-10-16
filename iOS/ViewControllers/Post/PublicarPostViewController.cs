using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;
using SVProgressHUDBinding;
using System.Collections.Generic;
using WorklabsMx.Enum;
using Photos;

namespace WorklabsMx.iOS
{
    public partial class PublicarPostViewController : UIViewController
    {
        
        SimpleStorage storageLocal;
        DateTime FechaActual;
        string Nombre;
        string Ocupacion;
        string ImagenPerfil;

        UIImagePickerController imagePicker;

        public PublicarPostViewController(IntPtr handle) : base(handle)
        {
            storageLocal = SimpleStorage.EditGroup("Login");
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            imagePicker.Delegate = this;
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
			this.btnPublicar.Enabled = false;
            this.btnPublicar.Layer.Opacity = 0.5f;
			this.txtPublicacion.Changed += HandleTextMessageChanged;
            FechaActual = DateTime.Now;
            lblFechaPublicacion.Text = String.Format("{0:dddd, d MMMM, yyyy}", FechaActual);  // "Sunday, March 9, 2008"
            imgPerfil.Image = ImageGallery.LoadImage(this.ImagenPerfil);

		}


		partial void btnPublicar_TouchUpInside(UIButton sender)
		{
			if (!SVProgressHUD.IsVisible)
			{
				SVProgressHUD.ShowWithStatus("Publicando Post");
			}
            if (new Controllers.EscritorioController().SetPost(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"), txtPublicacion.Text, "", this.imgPerfil.Image?.AsPNG().ToArray()))
            {
                SVProgressHUD.Dismiss();
                this.DismissViewController(true, null);
            }
            else 
            {
                SVProgressHUD.Dismiss();
                new MessageDialog().SendToast("No se pudo publicar el post");
            }
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
            var ShowGalleryAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);

            //Add Action
            ShowGalleryAlert.AddAction(this.AbrirGaleria(this.imagePicker));
            ShowGalleryAlert.AddAction(UIAlertAction.Create("Tomar fotografia", UIAlertActionStyle.Default, null));

            var CloseAction = UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, null);
            ShowGalleryAlert.AddAction(CloseAction);
            PresentViewController(ShowGalleryAlert, true, null);
        }

        [Foundation.Export("imagePickerController:didFinishPickingImage:editingInfo:")]
        public void FinishedPickingImage(UIKit.UIImagePickerController picker, UIKit.UIImage image, Foundation.NSDictionary editingInfo)
        {
            var ImagenSeleccionada = image;
        }

        [Foundation.Export("imagePickerControllerDidCancel:")]
        public void Canceled(UIKit.UIImagePickerController picker)
        {
            picker.DismissViewController(true, null);
        }

        private UIImagePickerController SelectImage(UIImagePickerController ImagePicker)
        {
            imagePicker.AllowsEditing = false;
            imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            imagePicker.AllowsEditing = true;
            return imagePicker;
        }

        private UIImagePickerController TakePhoto(UIImagePickerController ImagePicker)
        {
            imagePicker.AllowsEditing = false;
            imagePicker.SourceType = UIImagePickerControllerSourceType.Camera;
            imagePicker.CameraDevice = UIImagePickerControllerCameraDevice.Rear;
            imagePicker.AllowsEditing = true;
            return imagePicker;
        }

        private UIAlertAction AbrirGaleria(UIImagePickerController ImagePicker)
        {
            UIAlertAction openGalery = UIAlertAction.Create("Selecciona una foto", UIAlertActionStyle.Default, (action) =>
            {
                var photos = PHPhotoLibrary.AuthorizationStatus;
                if (photos != PHAuthorizationStatus.NotDetermined)
                {
                    this.PresentViewController(this.SelectImage(ImagePicker), true, null);
                }
                else 
                {
                    PHPhotoLibrary.RequestAuthorization(handler: (obj) => {
                        if (obj != PHAuthorizationStatus.Authorized)
                        {
                            this.PresentViewController(this.PermisosDispositivo(), true, null); 
                        }
                        else 
                        {
                            this.PresentViewController(this.SelectImage(ImagePicker), true, null);
                        }
                    });
                }
            });
            return openGalery;

        }

        private UIAlertController PermisosDispositivo()
        {
            var message = "Habilita el acceso de Worklabs a la cámara en la configuración iPhone";
            var alert = UIAlertController.Create("Se necesita acceso a la galeria", message, UIAlertControllerStyle.Alert);
            return alert;
        }

        
    }
}