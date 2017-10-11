using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using SVProgressHUDBinding;
using WorklabsMx.Controllers;

namespace WorklabsMx.iOS
{
    public partial class SeccionComentariosTableView : UITableView
    {

        public SeccionComentariosTableView (IntPtr handle) : base (handle)
        {

			const string IdentificadorCeldaPost = "CeldaComentario";
			const string IdentificadorCeldaNoInfo = "CeldaNoComentarios";

			const int TamañoPublicacion = 125;
			const int TamañoMensajeNoInfo = 400;


			bool isShowInformation = false;
			bool existeConeccion = true;

            if(InternetConectionHelper.VerificarConexion())
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
			if (allPosts.Count > 0)
			{
				isShowInformation = true;
				return allPosts.Count;
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
				var currentPost = allPosts[indexPath.Row];
				var currentPostCell = (ComentariosBodyCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
				currentPostCell.UpdateCell(currentPost);

				return currentPostCell;
			}
			else
			{
				var noPostCell = (NoComentsCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
				noPostCell.UpdateCell(this.existeConeccion);
				return noPostCell;
			}
		}



	}
}