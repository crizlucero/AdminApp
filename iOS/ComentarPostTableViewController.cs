using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using SVProgressHUDBinding;
using WorklabsMx.Models;

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
            StyleHelper.Style(vwSeccionComentarios.Layer);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            SVProgressHUD.Dismiss();
        }

		public override UIView GetViewForHeader(UITableView tableView, nint section)
		{
			var headerCell = (ComentarPostHeaderCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell();
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
				var comentariostView = (SeccionComentariosTableViewController)segue.DestinationViewController;
				comentariostView.setInfoPosto(LocalPost);
			}
			
		}

    }
}