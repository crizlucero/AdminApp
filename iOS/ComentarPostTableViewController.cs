using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using BigTed;

using Foundation;

namespace WorklabsMx.iOS
{
    public partial class ComentarPostTableViewController : UITableViewController
    {

		const string IdentificadorCeldaHeader = "CeldaComentar";
       
        const int TamañoHeader = 142;

        PostModel LocalPost;

        public ComentarPostTableViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            /*var tap = new UITapGestureRecognizer(this.handleTap);
            View.AddGestureRecognizer(tap);*/
            StyleHelper.Style(vwSeccionComentarios.Layer);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            BTProgressHUD.Dismiss();
        }

        private void handleTap(UITapGestureRecognizer reconizer)
        {
            this.View.EndEditing(true);
        }

		public override UIView GetViewForHeader(UITableView tableView, nint section)
		{
			var headerCell = (ComentarPostHeaderCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell(this.LocalPost);
			return headerCell;
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
                BTProgressHUD.Show(status: "Cargando comentarios");
				var comentariostView = (SeccionComentariosTableViewController)segue.DestinationViewController;
				comentariostView.setInfoPosto(this.LocalPost);
			}
			
		}
       

    }
}