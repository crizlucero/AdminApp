using System; using UIKit; using WorklabsMx.iOS.Helpers; using WorklabsMx.Models; using System.Collections.Generic; using WorklabsMx.Controllers; using BigTed; using System.Threading.Tasks;  namespace WorklabsMx.iOS {     public partial class EscritorioController : UITableViewController //UIViewController
    {
        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Post";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoPublicacion = 223;
        const int TamañoHeader = 120;
        const int TamañoMensajeNoInfo = 400;

        bool isShowInformation = false;
        bool existeConeccion = true;

        static int currentPage = 0;

        List<PostModel> posts;         List<PostModel> allPosts = new Controllers.EscritorioController().GetMuroPosts(currentPage);         List<string> miembro;         List<String> Likes = new List<string>();         List<UIImage> PostImages = new List<UIImage>();         PostModel CurrentPost;          UIImageView ImagenPerfil;

        public EscritorioController(IntPtr handle) : base(handle)         {
           
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();             currentPage = 0;             if (InternetConectionHelper.VerificarConexion())             {                 allPosts = new Controllers.EscritorioController().GetMuroPosts(currentPage);                 foreach (var post in allPosts)                 {                     var like = new Controllers.EscritorioController().GetLikesPublish(post.Publicacion_Id) + " LIKES";                     var PostImage = ImageGallery.LoadImage(post.Usuario_Fotografia_Ruta);                     Likes.Add(like);                     PostImages.Add(PostImage);                 }                 var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");                 miembro = new MiembrosController().GetMemberName(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));             }             else             {                 this.btnScanQr.Title = "";                 this.btnScanQr.Enabled = false;                 isShowInformation = false;                 existeConeccion = false;             } 
		}

        public override void ViewWillAppear(bool animated)
        {             base.ViewWillAppear(animated);
			
        }

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
                var currentPost = allPosts[indexPath.Row];                 var currentLike = Likes[indexPath.Row];                 var currentPostImage = PostImages[indexPath.Row];
                var currentPostCell = (ComentariosBodyCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
                currentPostCell.UpdateCell(currentPost, currentLike, currentPostImage);
                this.CurrentPost = currentPost;                 this.WillDisplay(indexPath.Row);
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
            if(segue.Identifier == "toShowPostView")             {                 var postCommentView = (PublicarPostViewController)segue.DestinationViewController;                 postCommentView.setInfoPublicacion(miembro);             }              else if(segue.Identifier == "comentarPost")             {
				var CommentView = (ComentarPostTableViewController)segue.DestinationViewController;
				CommentView.setInfoPost(this.CurrentPost);             }
        }          private async void WillDisplay(int Row)         {                          int LastRow = allPosts.Count - 1;              if ((Row == LastRow) && (LastRow < allPosts.Count))             {                 BTProgressHUD.Show();                 await Task.Delay(500);                 this.TableView.ScrollEnabled = false;                 if (InternetConectionHelper.VerificarConexion())                 {                     currentPage += 5;                     posts = new Controllers.EscritorioController().GetMuroPosts(currentPage);                     foreach (var post in posts)                     {                         allPosts.Add(post);                         var like = new Controllers.EscritorioController().GetLikesPublish(post.Publicacion_Id) + " LIKES";                         var PostImage = ImageGallery.LoadImage(post.Usuario_Fotografia_Ruta);                         Likes.Add(like);                         PostImages.Add(PostImage);                     }                     BTProgressHUD.Dismiss();                     this.TableView.ScrollEnabled = true;                     if (LastRow != allPosts.Count - 1){                         this.TableView.ReloadData();                     }                  }                 else                 {                     BTProgressHUD.Dismiss();                     this.TableView.ScrollEnabled = true;                     new MessageDialog().SendToast("No tienes acceso a una conexión de Internet, intenta de nuevo");                 }             }             BTProgressHUD.Dismiss();         } 
        partial void btnToScanQr_TouchUpInside(UIBarButtonItem sender)
        {
            this.PerformSegue("toScanQr", sender);
        }
    } } 