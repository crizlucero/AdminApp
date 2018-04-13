using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{

    public partial class TableViewLikes : UITableViewController
    {
        public List<UsuarioModel> UsuariosLikes = new List<UsuarioModel>();

        const string IdentificadorCeldaLike = "CeldaLike";
        const int TamanoCeldaLike = 65;

        public TableViewLikes (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
            var current = UsuariosLikes[indexPath.Row];
            var CeldaUsuarioLike = (CeldaLike)tableView.DequeueReusableCell(IdentificadorCeldaLike, indexPath);
            CeldaUsuarioLike.UpdateCell(current);
            //CeldaUsuarioLike.EventosComentariosDelegate = this;
            return CeldaUsuarioLike;
		}


        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return UsuariosLikes.Count;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return TamanoCeldaLike;
        }

       
	}
}