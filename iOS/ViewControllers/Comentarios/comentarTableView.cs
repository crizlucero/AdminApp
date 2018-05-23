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
        const int TamañoHeader = 186;

        bool isShowInformation = false;
        bool existeConeccion = true;

        List<ComentarioModel> comentarios;
        List<UIImage> allProfileImages = new List<UIImage>();
        List<UIImage> allCommentImages = new List<UIImage>();

        float withImage;
        int ContPag = 0;
        List<string> FotosId;
        List<string> FotosPerfilId;

        public comentarTableView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            withImage = float.Parse(UIScreen.MainScreen.Bounds.Width.ToString());
            FotosId = new List<string>();
            FotosPerfilId = new List<string>();
        }

        public async override void ViewWillAppear(bool animated)
        {
            BTProgressHUD.Show(status: "Cargando Comentarios");
            base.ViewWillAppear(animated);
            await MenuHelper.GetCommentPost(currentPost, ContPag, 5);
            this.comentarios = MenuHelper.Comentarios;
            this.TableView.ReloadData();
            this.TableView.BeginUpdates();
            this.TableView.EndUpdates();
            BTProgressHUD.Dismiss();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (HeaderComentarTableView)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell(currentPost);
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

        async void GetPost(NSIndexPath indexPath)
        {
            await MenuHelper.GetCommentPost(currentPost, ContPag, 5);
            foreach (ComentarioModel cometario in MenuHelper.Comentarios)
            {
                TableView.BeginUpdates();
                this.comentarios.Add(cometario);
                TableView.InsertRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.None);
                TableView.EndUpdates();
            }

        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                if (indexPath.Row == comentarios.Count - 1)
                {
                    ContPag++;
                    this.GetPost(indexPath);
                }
                var currentComment = comentarios[indexPath.Row];
                if ((currentComment.Comentario_Imagen_Ruta != null && currentComment.Comentario_Imagen_Ruta != "") && (currentComment.Comentario_Imagen != null && currentComment.Comentario_Imagen != ""))
                {
                    var currentPostImageCell = (ComentarImageTableViewCell)tableView.DequeueReusableCell(IdentificadorImageCeldaPost, indexPath);
                    currentPostImageCell.UpdateCell(currentComment, this.FotosId, this.FotosPerfilId);
                    currentPostImageCell.EventosImagenDel = this;
                    return currentPostImageCell;
                }
                else
                {
                    var currentPostCell = (BodyComentarTableView)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
                    currentPostCell.UpdateCell(currentComment);
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
                await MenuHelper.GetCommentPost(currentPost, ContPag, 5);
                this.comentarios = MenuHelper.Comentarios;
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
            //await MenuHelper.GetMuroPosts();
            await MenuHelper.GetCommentPost(currentPost, ContPag, 5);
            this.comentarios = MenuHelper.Comentarios;
            TableView.ReloadData();
            this.TableView.BeginUpdates();
            this.TableView.EndUpdates();
        }

        public void ImagenPublicada(List<string> FotosId)
        {
            this.FotosId = FotosId;
        }

        public void ImagenPerfilPublicada(List<string> FotosPerfilId)
        {
            this.FotosPerfilId = FotosPerfilId;
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
            await MenuHelper.GetCommentPost(currentPost, ContPag, 5);
            this.comentarios = MenuHelper.Comentarios;
            TableView.ReloadData();
            this.TableView.BeginUpdates();
            this.TableView.EndUpdates();
        }
    }
}