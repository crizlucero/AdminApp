using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using System.Threading.Tasks;
using System.Threading;
using Foundation;


namespace WorklabsMx.iOS
{

    public partial class comentarTableView : UITableViewController
    {

        //public BackWindow BackWindowDelegate;

        public PostModel currentPost;

        public UIImage currentProfileImage = new UIImage();
        public UIImage currentPostImage = new UIImage();

        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Body";
        const string IdentificadorImageCeldaPost = "BodyImage";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoMensajeNoInfo = 400;
        const int TamañoHeader = 150;

        bool isShowInformation = false;
        bool existeConeccion = true;

        List<ComentarioModel> comentarios;
        List<UIImage> allProfileImages = new List<UIImage>();
        List<UIImage> allCommentImages = new List<UIImage>();

        float withImage;

        public comentarTableView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            withImage = float.Parse(UIScreen.MainScreen.Bounds.Width.ToString());
        }

        public async override void ViewWillAppear(bool animated)
        {
            BTProgressHUD.Show(status: "Cargando Comentarios");
            base.ViewWillAppear(animated);
            await FillData();
            this.TableView.ReloadData();
            this.TableView.BeginUpdates();
            this.TableView.EndUpdates();
            BTProgressHUD.Dismiss();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            //await Task.Delay(2000);
          
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (HeaderComentarTableView)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell(currentPost, currentProfileImage, currentPostImage);
            return headerCell;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (comentarios == null)
            {
                return 0;
            }
            else
            {
                if (comentarios.Count > 0)
                {
                    isShowInformation = true;
                    return comentarios.Count;
                }
                isShowInformation = false;
                return 1;
            }
        }

        partial void btnBack_TouchUpInside(UIBarButtonItem sender)
        {
            this.NavigationController.PopViewController(true);
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var currentComment = comentarios[indexPath.Row];

                var currentImageProfile = allProfileImages[indexPath.Row];
                var currentImageComments = allCommentImages[indexPath.Row];

                if(currentImageComments != null)
                {
                    var currentPostImageCell = (ComentarImageTableViewCell)tableView.DequeueReusableCell(IdentificadorImageCeldaPost, indexPath);
                    currentPostImageCell.UpdateCell(currentComment, currentImageProfile, currentImageComments);
                    currentPostImageCell.EventosImagenDel = this;
                    return currentPostImageCell;
                }
                else
                {
                    var currentPostCell = (BodyComentarTableView)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
                    currentPostCell.UpdateCell(currentComment, currentImageProfile);
                    currentPostCell.EventosImagenComentarDel = this;
                    return currentPostCell;
                }

               
            }
            else
            {
                var noPostCell = (ComentarNoInfoCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }

        }

        async Task FillData()
        {
            await Task.Run(() =>
           {
               allCommentImages = new List<UIImage>();
               allProfileImages = new List<UIImage>();
               if (InternetConectionHelper.VerificarConexion())
               {
                   this.comentarios = new Controllers.EscritorioController().GetComentariosPost(currentPost.Publicacion_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
                   foreach (ComentarioModel comentario in this.comentarios)
                   {
                       if (currentPost.Publicacion_Imagen_Post != null)
                       {
                           var data = NSData.FromArray(currentPost.Publicacion_Imagen_Post);
                           var uiimage = UIImage.LoadFromData(data);
                           var porcentajeWith = ((withImage * 100) / uiimage.CGImage.Height);
                           var HeightImage = uiimage.CGImage.Height * (porcentajeWith / 100);
                           var ReescalImage = ImageHelper.ResizeUIImage(uiimage, withImage, HeightImage);
                           allCommentImages.Add(ReescalImage);
                       }
                       else
                       {
                            allCommentImages.Add(null);
                       }
                       allProfileImages.Add(ImageGallery.LoadImage(currentPost.Usuario.Usuario_Fotografia) ?? UIImage.FromBundle("ProfileImage"));

                   }
               }
               else
               {
                   existeConeccion = false;
                   isShowInformation = false;
               }
           });
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "comentarpublicacion")
            {
                var ComentarioView = (ComentarviewController)segue.DestinationViewController;
                ComentarioView.ComentarioDelegate = this;
            }
        }

    }

    partial class comentarTableView : ComentarioRealizado
    {
        public async void ComentarioRealizado(String Comentario, UIImage ImagenPublicacion)
        {
            byte[] Fotografia = new byte[0];

            if (ImagenPublicacion != null)
            {
                Fotografia = ImagenPublicacion?.AsPNG().ToArray();
            }

            if (new Controllers.EscritorioController().CommentPost(currentPost.Publicacion_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Comentario, Fotografia))
            {
                await FillData();
                TableView.ReloadData();
                this.TableView.BeginUpdates();
                this.TableView.EndUpdates();
            }
        }
    }

    partial class comentarTableView : EventosImagen
    {
        public void MostrarImagenEnGrandes(UIImageView Imagen)
        {
            this.PerformSegue("ToViewImageFromComment", Imagen);
        }

        public void EnviarActions(UIAlertController actionSheetAlert)
        {

            UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;
            if (presentationPopover != null)
            {
                presentationPopover.SourceView = this.View;
                presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;
            }
            this.PresentViewController(actionSheetAlert, true, null);
        }

        public async void ActualizaTabla()
        {
            await MenuHelper.GetMuroPosts();
            await FillData();
            TableView.ReloadData();
            this.TableView.BeginUpdates();
            this.TableView.EndUpdates();
        }
    }

    partial class comentarTableView : EventosImagenComentar
    {
        public void MostrarImagenEnGrandesComentar(UIImageView Imagen)
        {
            this.PerformSegue("ToViewImageFromComment", Imagen);
        }

        public void EnviarAction(UIAlertController actionSheetAlert)
        {

            UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;
            if (presentationPopover != null)
            {
                presentationPopover.SourceView = this.View;
                presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;
            }
            this.PresentViewController(actionSheetAlert, true, null);
        }

        public async void ActualizarTabla()
        {
            await FillData();
            TableView.ReloadData();
            this.TableView.BeginUpdates();
            this.TableView.EndUpdates();
        }
    }
}