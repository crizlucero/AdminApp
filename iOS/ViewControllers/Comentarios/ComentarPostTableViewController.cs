using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using BigTed;
using Foundation;
using System.Threading.Tasks;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class ComentarPostTableViewController : UITableViewController
    {

		const string IdentificadorCeldaHeader = "CeldaComentar";
       
        const int TamañoHeader = 141;

        PostModel LocalPost;

        SeccionComentariosTableViewController objSeccionComentarios;

        UITextView TextoComentario;

        UIImagePickerController imgPicker;

        UIImage SelectedImage;

        nfloat size; 

        public ComentarPostTableViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            imgPicker = new UIImagePickerController();
            imgPicker.Delegate = this;
             var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
            StyleHelper.Style(vwSeccionComentarios.Layer);
            size = UIScreen.MainScreen.Bounds.Height - TamañoHeader - 100;
            this.vwVistaSeccionComentarios.Frame = new CGRect(this.vwVistaSeccionComentarios.Frame.X, this.vwVistaSeccionComentarios.Frame.Y, this.vwVistaSeccionComentarios.Frame.Width, size);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        void PostComentato(object sender, EventArgs e)
        {
            objSeccionComentarios.setInfoPosto(this.LocalPost);
        }

        void TextoEscrito(object sender, EventArgs e)
        {
            TextoComentario = (UITextView)sender;
        }

        void MostrarActionSheet(object sender, EventArgs e)
        {
            PresentViewController(CrearActionSheet(), true, null);
        }

        void MostrarImagenEnGrande(object sender, EventArgs e)
        {
            this.PerformSegue("toViewImageFromComments", (UIImageView)sender);
        }


		public override UIView GetViewForHeader(UITableView tableView, nint section)
		{
			var headerCell = (ComentarPostHeaderCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.getText(TextoComentario);
            headerCell.UpdateCell(this.LocalPost);
            headerCell.PostComentado += PostComentato;
            headerCell.TextoEscrito += TextoEscrito;
            headerCell.MostrarActionSheet += MostrarActionSheet;
            headerCell.MostrarImagenEnGrande += MostrarImagenEnGrande;
            headerCell.getConfigImageLoaded(SelectedImage);
			return headerCell.ContentView;
		}

		public override nfloat GetHeightForHeader(UITableView tableView, nint section)
		{
			return TamañoHeader;
		}


		public void setInfoPost(PostModel Post)
		{
            this.LocalPost = Post;
		}

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
            
			if (segue.Identifier == "SeccionComentarios")
			{
                var comentariostView = (SeccionComentariosTableViewController)segue.DestinationViewController;
                objSeccionComentarios = comentariostView;
                try
                {
                    comentariostView.setInfoPosto(this.LocalPost);
                }
                catch(Exception e)
                {
                    SlackLogs.SendMessage(e.Message);
                }
				
			}
            else if (segue.Identifier == "toViewImageFromComments")
            {
                var postCommentView = (DetailCommentImage)segue.DestinationViewController;
                postCommentView.ImagenPost = (UIImageView)sender;
            }
			
		}

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
            //this.TableView.ReloadData();
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
            SelectedImage = image;
            this.View.EndEditing(true);
            this.TableView.ReloadData();
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
       

    }
}