using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using BigTed;
using PerpetualEngine.Storage;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class SeccionComentariosTableViewController : UITableViewController
    {

		const string IdentificadorCeldaPost = "CeldaComentario";
		const string IdentificadorCeldaNoInfo = "CeldaNoComentarios";

		const int TamañoPublicacion = 156;
		const int TamañoMensajeNoInfo = 400;


		bool isShowInformation = false;
		bool existeConeccion = true;

        SimpleStorage storageLocal;

        PostModel PostLocal;

        List<ComentarioModel> comentarios;
        List<UIImage> allProfileImages = new List<UIImage>();
        List<UIImage> allCommentImages = new List<UIImage>();

        public SeccionComentariosTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
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

		public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			if (isShowInformation)
			{
                if (comentarios[indexPath.Row].Comentario_Imagen_Ruta == "")
                {
                    return TamañoPublicacion - 50;
                }
                else 
                {
                    return TamañoPublicacion;
                }
				
			}
			else
			{
				return TamañoMensajeNoInfo;
			}
		}


		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
           
			if (isShowInformation)
			{
				var currentPost = comentarios[indexPath.Row];
				var currentPostCell = (ComentarioViewCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
                var currentImageProfile = allProfileImages[indexPath.Row];
                var currentImageComments = allCommentImages[indexPath.Row];
                currentPostCell.UpdateCell(currentPost, currentImageProfile, currentImageComments);
                currentPostCell.MostrarImagenEnGrande += MostrarImagenEnGrande;
                this.WillDisplay(indexPath.Row);
				return currentPostCell;
			}
			else
			{
				var noPostCell = (NoComentariosViewCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
				noPostCell.UpdateCell(this.existeConeccion);
				return noPostCell;
			}

		}

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "ToViewImageFromComment")
            {
                var ImageView = (DetailCommentImage)segue.DestinationViewController;
                ImageView.ImagenPost = (UIImageView)sender;
            }
        }

        void MostrarImagenEnGrande(object sender, EventArgs e)
        {
            this.PerformSegue("ToViewImageFromComment", (UIImageView)sender);
        }

		public async void setInfoPosto(PostModel Post)
		{
            BTProgressHUD.Show(status: "Cargando comentarios");
            await Task.Delay(500);
            storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            if (InternetConectionHelper.VerificarConexion())
            {
                PostLocal = Post;
                this.comentarios = new Controllers.EscritorioController().GetComentariosPost(Post.Publicacion_Id,storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));
                foreach(ComentarioModel comentario in this.comentarios)
                {
                    allCommentImages.Add(ImageGallery.LoadImage(comentario.Comentario_Imagen_Ruta));
                    allProfileImages.Add(ImageGallery.LoadImage(comentario.Usuario_Fotografia_Ruta));
                }
            }
            else
            {
                isShowInformation = false;
                existeConeccion = false;
            }

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

    }
}