using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class SeccionComentariosTableViewController : UITableViewController
    {

		const string IdentificadorCeldaPost = "CeldaComentario";
		const string IdentificadorCeldaNoInfo = "CeldaNoComentarios";

		const int TamañoPublicacion = 125;
		const int TamañoMensajeNoInfo = 400;


		bool isShowInformation = false;
		bool existeConeccion = true;

        PostModel LocalPost;

        List<ComentarioModel> comentarios = new List<ComentarioModel>();

        public SeccionComentariosTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

			if (InternetConectionHelper.VerificarConexion())
			{
                
			}
			else
			{
				isShowInformation = false;
				existeConeccion = false;
			}
        }


		public override nint RowsInSection(UITableView tableView, nint section)
		{
			if (comentarios.Count > 0)
			{
				isShowInformation = true;
				return comentarios.Count;
			}
			isShowInformation = false;
			return 0;
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
            this.LocalPost = Post;
            comentarios = new Controllers.EscritorioController().GetComentariosPost(this.LocalPost.POST_ID);
            this.TableView.ReloadData();
		}


    }
}