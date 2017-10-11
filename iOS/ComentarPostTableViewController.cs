using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using SVProgressHUDBinding;

namespace WorklabsMx.iOS
{
    public partial class ComentarPostTableViewController : UITableViewController
    {
		const string IdentificadorCeldaHeader = "CeldaComentar";
        const int TamañoHeader = 142;

        public ComentarPostTableViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            StyleHelper.Style(this.vwSeccionComentarios.Layer);
            SVProgressHUD.Dismiss();
        }

		public override UIView GetViewForHeader(UITableView tableView, nint section)
		{
			var headerCell = (ComentarPostHeaderCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
			return headerCell;
		}

		public override nfloat GetHeightForHeader(UITableView tableView, nint section)
		{
			return TamañoHeader;
		}
        

    }
}