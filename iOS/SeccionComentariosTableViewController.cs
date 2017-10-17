using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using BigTed;
using Foundation;

namespace WorklabsMx.iOS
{
    public partial class SeccionComentariosTableViewController : UITableViewController
    {

		const string IdentificadorCeldaPost = "CeldaComentario";
		const string IdentificadorCeldaNoInfo = "CeldaNoComentarios";

		const int TamañoPublicacion = 100;
		const int TamañoMensajeNoInfo = 400;


		bool isShowInformation = false;
		bool existeConeccion = true;

        List<UIImage> ImagenesComentario = new List<UIImage>();
        List<ComentarioModel> comentarios;

        public SeccionComentariosTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            foreach (var comentario in comentarios)
            {
                var ImagenComentario = ImageGallery.LoadImage(comentario.Miembro_Fotografia);
                ImagenesComentario.Add(ImagenComentario);
            }
            /*var tap = new UITapGestureRecognizer(this.handleTap);
            View.AddGestureRecognizer(tap);*/

            BTProgressHUD.Dismiss();
        }

        private void handleTap (UITapGestureRecognizer reconizer)
        {
            this.View.EndEditing(true);
        }

		public override nint RowsInSection(UITableView tableView, nint section)
		{
			if (comentarios.Count > 0)
			{
				isShowInformation = true;
				return comentarios.Count;
			}
			isShowInformation = false;
			return 1;
		}

		public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			if (isShowInformation)
			{
				return TamañoPublicacion;
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
				currentPostCell.UpdateCell(currentPost);
				return currentPostCell;
			}
			else
			{
				var noPostCell = (NoComentariosViewCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
				noPostCell.UpdateCell(this.existeConeccion);
				return noPostCell;
			}

		}

		public void setInfoPosto(PostModel Post)
		{
            if (InternetConectionHelper.VerificarConexion())
            {
                this.comentarios = new Controllers.EscritorioController().GetComentariosPost(Post.POST_ID);
            }
            else
            {
                isShowInformation = false;
                existeConeccion = false;
            }
            this.TableView.ReloadData();
		}

        public void evHandler(Object sender)
        {
            // need someData here!!!
        }
    }
}