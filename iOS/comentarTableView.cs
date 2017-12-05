using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;

namespace WorklabsMx.iOS
{
    public partial class comentarTableView : UITableViewController
    {

        public PostModel currentPost;

        public UIImage currentProfileImage = new UIImage();
        public UIImage currentPostImage = new UIImage();

        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Body";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoMensajeNoInfo = 400;

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
            if (InternetConectionHelper.VerificarConexion())
            {
                this.comentarios = new Controllers.EscritorioController().GetComentariosPost(currentPost.Publicacion_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
                foreach (ComentarioModel comentario in this.comentarios)
                {
                    allCommentImages.Add(ImageGallery.LoadImage(comentario.Comentario_Imagen_Ruta));
                    allProfileImages.Add(ImageGallery.LoadImage(comentario.Usuario_Fotografia_Ruta));
                }
            } else
            {
                existeConeccion = false;
                isShowInformation = false;
            }
           
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

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

        private void WillDisplay(int Row)
        {
            int LastRow = this.comentarios.Count - 1;
            if ((Row == LastRow) /*&& (LastRow < allPosts.Count)*/)
            {
                BTProgressHUD.Dismiss();
            }
        }


    }
}