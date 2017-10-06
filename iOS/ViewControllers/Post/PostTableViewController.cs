using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.ViewControllers.Post;

namespace WorklabsMx.iOS
{
    public class PostTableViewController: UITableViewController
    {
        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Post";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        bool isShowInformation = false;

        MiembroModel miembro;

		public PostTableViewController(IntPtr handle) : base(handle)
        {
            
		}

		public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (ComentariosHeaderCell) tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell(miembro);
            return headerCell;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return 120;
        }


        public override nint NumberOfSections(UITableView tableView)
        {
            isShowInformation = false;
            return 0;
        }

        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if(isShowInformation)
            {
                return 170;
            }
            else 
            {
                return 400;
            }
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var currentCell = tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath) as PostBodyCell;
                return currentCell;
            }
            else 
            {
                var noPostCell = tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath) as PostBodyCell;
                return noPostCell;
            }
        }

    }
}
