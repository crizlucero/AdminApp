using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{

    /*public interface BackWindow
    {
        void BackWindow();
    }*/

    public partial class comentarTableView : UITableViewController
    {

        //public BackWindow BackWindowDelegate;

        public PostModel currentPost;

        public UIImage currentProfileImage = new UIImage();
        public UIImage currentPostImage = new UIImage();

        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Body";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoMensajeNoInfo = 400;
        const int TamañoHeader = 207;

        bool isShowInformation = false;
        bool existeConeccion = true;

        List<ComentarioModel> comentarios;
        List<UIImage> allProfileImages = new List<UIImage>();
        List<UIImage> allCommentImages = new List<UIImage>();

        public comentarTableView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.ReloadData();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            //await Task.Delay(2000);
            BTProgressHUD.Show(status: "Cargando Comentarios");
        }

        void MostrarImagenEnGrandes(object sender, EventArgs e)
        {
            this.PerformSegue("ToViewImageFromComment", (UIImageView)sender);
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
            //this.BackWindowDelegate.BackWindow();
            this.NavigationController.PopViewController(true);
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var currentComment = comentarios[indexPath.Row];
                var currentPostCell = (BodyComentarTableView)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
                var currentImageProfile = allProfileImages[indexPath.Row];
                var currentImageComments = allCommentImages[indexPath.Row];
                currentPostCell.UpdateCell(currentComment, currentImageProfile, currentImageComments);
                currentPostCell.MostrarImagenEnGrandes += MostrarImagenEnGrandes;
                this.WillDisplay(indexPath.Row);
                return currentPostCell;
            }
            else
            {
                var noPostCell = (ComentarNoInfoCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }

        }

        private void ReloadData()
        {
            allCommentImages = new List<UIImage>();
            allProfileImages = new List<UIImage>();
            if (InternetConectionHelper.VerificarConexion())
            {
                this.comentarios = new Controllers.EscritorioController().GetComentariosPost(currentPost.Publicacion_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
                foreach (ComentarioModel comentario in this.comentarios)
                {
                    allCommentImages.Add(ImageGallery.LoadImage(comentario.Comentario_Imagen_Ruta));
                    allProfileImages.Add(ImageGallery.LoadImage(comentario.Usuario_Fotografia_Ruta));
                }
            }
            else
            {
                existeConeccion = false;
                isShowInformation = false;
            }
            BTProgressHUD.Dismiss();
            this.TableView.ReloadData();
        }

        private void WillDisplay(int Row)
        {
            int LastRow = this.comentarios.Count - 1;
            if ((Row == LastRow) /*&& (LastRow < allPosts.Count)*/)
            {
                BTProgressHUD.Dismiss();
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
        public void ComentarioRealizado(String Comentario)
        {
            byte[] Fotografia = new byte[0];

            /*if (ImagenPublicacion != null)
            {
                Fotografia = ImagenPublicacion?.AsPNG().ToArray();
            }*/


            if (new Controllers.EscritorioController().CommentPost(currentPost.Publicacion_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Comentario, Fotografia))
            {
                this.ReloadData();
            }
        }
    }
}