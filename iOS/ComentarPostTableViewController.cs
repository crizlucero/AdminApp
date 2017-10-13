using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using BigTed;
using CoreGraphics;

using Foundation;

namespace WorklabsMx.iOS
{
    public partial class ComentarPostTableViewController : UITableViewController
    {

		const string IdentificadorCeldaHeader = "CeldaComentar";
       
        const int TamañoHeader = 130;

        PostModel LocalPost;

        SeccionComentariosTableViewController objSeccionComentarios;


        public ComentarPostTableViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //CGRect newFrame = new CGRect(this.vwVistaSeccionComentarios.Frame.X, this.vwVistaSeccionComentarios.Frame.Y, this.vwVistaSeccionComentarios.Frame.Width, 150);
            //this.vwVistaSeccionComentarios.Frame = newFrame;
            /*var tap = new UITapGestureRecognizer(this.handleTap);
            View.AddGestureRecognizer(tap);*/
            StyleHelper.Style(vwSeccionComentarios.Layer);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            BTProgressHUD.Dismiss();
        }


        void PostComentato(object sender, EventArgs e)
        {
            objSeccionComentarios.setInfoPosto(this.LocalPost);
        }

        private void handleTap(UITapGestureRecognizer reconizer)
        {
            this.View.EndEditing(true);
        }

		public override UIView GetViewForHeader(UITableView tableView, nint section)
		{
			var headerCell = (ComentarPostHeaderCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell(this.LocalPost);
            headerCell.PostComentado += PostComentato;
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
                objSeccionComentarios = comentariostView;
				comentariostView.setInfoPosto(this.LocalPost);
			}
			
		}
       

    }
}