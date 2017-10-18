using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using BigTed;
using CoreGraphics;
using Foundation;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class ComentarPostTableViewController : UITableViewController
    {

		const string IdentificadorCeldaHeader = "CeldaComentar";
       
        const int TamañoHeader = 130;

        PostModel LocalPost;

        SeccionComentariosTableViewController objSeccionComentarios;

        UITextView TextoComentario;

        public ComentarPostTableViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
             var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
            StyleHelper.Style(vwSeccionComentarios.Layer);
            BTProgressHUD.Dismiss();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }


        void PostComentato(object sender, EventArgs e)
        {
            objSeccionComentarios.setInfoPosto(this.LocalPost);
        }

        void TextoEscrito(object sender, EventArgs e)
        {
            TextoComentario = (UITextView)sender;
        }


		public override UIView GetViewForHeader(UITableView tableView, nint section)
		{
			var headerCell = (ComentarPostHeaderCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.getText(TextoComentario);
            headerCell.UpdateCell(this.LocalPost);
            headerCell.PostComentado += PostComentato;
            headerCell.TextoEscrito += TextoEscrito;

			return headerCell.ContentView;
		}

		public override nfloat GetHeightForHeader(UITableView tableView, nint section)
		{
			return TamañoHeader;
		}


		public void setInfoPost(PostModel Post)
		{
            this.LocalPost = Post;
		}

        public async override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
            BTProgressHUD.Show(status: "Cargando comentarios");
            await Task.Delay(500);
			if (segue.Identifier == "SeccionComentarios")
			{
                var comentariostView = (SeccionComentariosTableViewController)segue.DestinationViewController;
                objSeccionComentarios = comentariostView;
				comentariostView.setInfoPosto(this.LocalPost);
			}
			
		}

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
            this.TableView.ReloadData();
        }
       

    }
}