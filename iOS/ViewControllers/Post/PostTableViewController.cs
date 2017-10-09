using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;
using SVProgressHUDBinding;

namespace WorklabsMx.iOS
{
    public class PostTableViewController: UITableViewController
    {
        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Post";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoPublicacion = 190;
        const int TamañoHeader = 120;
        const int TamañoMensajeNoInfo = 400;

        bool isShowInformation = false;
        bool existeConeccion = true;

        MiembroModel miembro;
        static int currentPage = 0;

        List<PostModel> posts; 

 
		public PostTableViewController(IntPtr handle) : base(handle)
        {
            posts = new List<PostModel>();
		}

		public override void ViewDidLoad()
        {
			base.ViewDidLoad();
            if (InternetConectionHelper.VerificarConexion())
            {
				this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_qr"), UIBarButtonItemStyle.Plain, (sender, e) =>
				{
					UIActivityIndicatorView waiting = new UIActivityIndicatorView
					{
						Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 2, UIScreen.MainScreen.Bounds.Height / 2, 30, 30)
					};
					View.AddSubview(waiting);
					UIViewController controller = this.Storyboard.InstantiateViewController("AccesoController");
					controller.Title = "Control de Acceso";
					this.NavigationController.PushViewController(controller, true);
				}), true);
				posts = new Controllers.EscritorioController().GetMuroPosts(currentPage);
            } else {
                isShowInformation = false;
                existeConeccion = false;
            }
          
            SVProgressHUD.Dismiss();
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
            return TamañoHeader;
        }


        public override nint NumberOfSections(UITableView tableView)
        {
            if (posts.Count > 0)
            {
                isShowInformation = true;
                return posts.Count;
            }
            isShowInformation = false;
            return 0;
        }

        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if(isShowInformation)
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
                var currentPost = posts[indexPath.Row];
                var currentPostCell = (ComentariosBodyCell) tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
                currentPostCell.UpdateCell(currentPost);
                return currentPostCell;
            }
            else 
            {
                var noPostCell = (NoComentsCell) tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }

        public override void WillDisplay(UITableView tableView, UITableViewCell cell, Foundation.NSIndexPath indexPath)
        {
            var lastElement = posts.Count - 1;
            if (indexPath.Row == lastElement) 
            {
                currentPage += 5;
                //this.TableView.ReloadData();
			}
        }

    }
}
