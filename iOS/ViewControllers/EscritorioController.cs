using System; using UIKit; using WorklabsMx.iOS.Helpers; using WorklabsMx.Models; using System.Collections.Generic; using WorklabsMx.Controllers; using BigTed;  namespace WorklabsMx.iOS {     public partial class EscritorioController : UITableViewController
    {
        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Post";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoPublicacion = 223;
        const int TamañoHeader = 120;
        const int TamañoMensajeNoInfo = 400;

        bool isShowInformation = false;
        bool existeConeccion = true;
         List<PostModel> allPosts = new List<PostModel>();         List<string> miembro;         PostModel CurrentPost;          UIImageView ImagenPerfil; 
        public EscritorioController(IntPtr handle) : base(handle)         {
            
        }

        public override void ViewDidLoad()
        {             /*if (!BTProgressHUD.IsVisible)             {                 BTProgressHUD.Show();             }*/
            base.ViewDidLoad();
		}

        public override void ViewWillAppear(bool animated)
        {             base.ViewWillAppear(animated);
            this.CargarInfo();             this.TableView.ReloadData();
        }          public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);             BTProgressHUD.Dismiss();
        }
         void MostrarImagenEnGrande(object sender, EventArgs e)         {             this.PerformSegue("toShowImageFromPost", (UIImageView)sender);         }          void ComentarPost(object sender, EventArgs e)         {             CurrentPost = (PostModel)sender;         } 
        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {             
            var headerCell = (ComentariosHeaderCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
             headerCell.UpdateCell(miembro);             this.ImagenPerfil = headerCell.getImagenPerfil();
            return headerCell;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }
         

        public override nint RowsInSection(UITableView tableView, nint section)
        {
			if (allPosts.Count > 0)
			{
				isShowInformation = true;
				return allPosts.Count;
			}
			isShowInformation = false;
			return 1;
        }
  
        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {                  if (allPosts[indexPath.Row].Publicacion_Imagen_Ruta == "")                 {                     return TamañoPublicacion - 50;                 }                 else                  {                     return TamañoPublicacion;                 }

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
                currentPostCell.UpdateCell(currentPost);                 currentPostCell.MostrarImagenEnGrande += MostrarImagenEnGrande;                 currentPostCell.ComentarPost += ComentarPost;                 //this.WillDisplay(indexPath.Row);                 //BTProgressHUD.Dismiss();
                return currentPostCell;
            }
            else
            {
                var noPostCell = (NoComentsCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }          public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if(segue.Identifier == "toShowPostView")             {                 var postCommentView = (PublicarPostViewController)segue.DestinationViewController;                 postCommentView.PostPublicadoDelegate = this;                 postCommentView.setInfoPublicacion(miembro);             }              else if(segue.Identifier == "comentarPost")             {
				var CommentView = (ComentarPostTableViewController)segue.DestinationViewController;
                CommentView.setInfoPost(CurrentPost);             }             else if(segue.Identifier == "toShowImageFromPost")             {                 var ImageView = (DetailCommentImage)segue.DestinationViewController;                 ImageView.ImagenPost = (UIImageView)sender;             }
        }          /* private void WillDisplay(int Row)         {             int LastRow = allPosts.Count - 1;             if ((Row == LastRow) /& (LastRow < allPosts.Count))             {                 BTProgressHUD.Dismiss();
                BTProgressHUD.Show();                 await Task.Delay(500);                 this.TableView.ScrollEnabled = false;                 if (InternetConectionHelper.VerificarConexion())                 {                     var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");                     allPosts = new Controllers.EscritorioController().GetMuroPosts(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));                     BTProgressHUD.Dismiss();                     this.TableView.ScrollEnabled = true;                     if (LastRow != allPosts.Count - 1)                     {                         this.TableView.ReloadData();                     }                  }                 else                 {                     BTProgressHUD.Dismiss();                     this.TableView.ScrollEnabled = true;                     new MessageDialog().SendToast("No tienes acceso a una conexión de Internet, intenta de nuevo");                 }             }             BTProgressHUD.Dismiss();
            }         }*/           private void CargarInfo()         {             if (InternetConectionHelper.VerificarConexion())             {                 var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");                 allPosts = new Controllers.EscritorioController().GetMuroPosts(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));                 miembro = new MiembrosController().GetMemberName(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));             }             else             {                 this.btnScanQr.Title = "";                 this.btnScanQr.Enabled = false;                 isShowInformation = false;                 existeConeccion = false;             }         } 
        partial void btnToScanQr_TouchUpInside(UIBarButtonItem sender)
        {
            this.PerformSegue("toScanQr", sender);
        } 
    }       partial class EscritorioController: PostPublicadoDel     {         public void PostPublicado()         {             this.CargarInfo();             this.TableView.ReloadData();         }     }  } 