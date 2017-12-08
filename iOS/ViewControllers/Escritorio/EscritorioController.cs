using System; using UIKit; using WorklabsMx.iOS.Helpers; using WorklabsMx.Models; using System.Collections.Generic; using WorklabsMx.Controllers; using BigTed; using WorklabsMx.Helpers; using System.Threading.Tasks;  namespace WorklabsMx.iOS {     public partial class EscritorioController : UITableViewController
    {
        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Post";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoPublicacion = 223;
        const int TamañoHeader = 93;
        const int TamañoMensajeNoInfo = 400;

        bool isShowInformation = false;
        bool existeConeccion = true;
         List<PostModel> allPosts = new List<PostModel>();         List<UIImage> allProfileImages = new List<UIImage>();         List<UIImage> allPostImages = new List<UIImage>();         List<string> miembro;          PostModel CurrentPost = new PostModel();         UIImage currentProfileImage = new UIImage();         UIImage currentPostImage = new UIImage();         UIImageView ImagenPerfil;         int ContadorComentar; 
        public EscritorioController(IntPtr handle) : base(handle)         {             
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
		}

        public override void ViewWillAppear(bool animated)
        {             base.ViewWillAppear(animated);             ContadorComentar = 0;
            this.CargarInfo();             this.TableView.ReloadData();             BTProgressHUD.Dismiss();
        }          public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }
         void MostrarImagenEnGrande(object sender, EventArgs e)         {             this.PerformSegue("toShowImageFromPost", (UIImageView)sender);         }          async void ComentarPost(object sender, EventArgs e)         {             CurrentPost = (PostModel)sender;             ContadorComentar = ContadorComentar + 1;             if(ContadorComentar <= 1)             {                 BTProgressHUD.Show(status: "Cargando Comentarios");                 await Task.Delay(2000);                 currentProfileImage = ImageGallery.LoadImage(CurrentPost.Usuario_Fotografia_Ruta);                 currentPostImage = ImageGallery.LoadImage(CurrentPost.Publicacion_Imagen_Ruta);                 this.PerformSegue("comentar", null);             }          }          public override UIView GetViewForHeader(UITableView tableView, nint section)
        {             var headerCell = (EscritorioHeaderCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);             headerCell.UpdateCell(miembro);             this.ImagenPerfil = headerCell.getImagenPerfil();             StyleHelper.Style(headerCell.Layer);
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
        /*public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {                 if (allPosts[indexPath.Row].Publicacion_Imagen_Ruta == "")                 {                     return TamañoPublicacion - 50;                 }                 else                  {                     return TamañoPublicacion;                 }

            }
            else
            {
                return TamañoMensajeNoInfo;
            }
        }*/

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var current = allPosts[indexPath.Row];
                var currentPostCell = (ComentariosBodyCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);                 var currentImageProfile = allProfileImages[indexPath.Row];                 var currentImagePost = allPostImages[indexPath.Row];
                currentPostCell.UpdateCell(current, currentImageProfile, currentImagePost);                 currentPostCell.MostrarImagenEnGrande += MostrarImagenEnGrande;                 currentPostCell.ComentarPost += ComentarPost;                 this.WillDisplay(indexPath.Row);
                return currentPostCell;
            }
            else
            {                 BTProgressHUD.Dismiss();
                var noPostCell = (NoComentsCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }          public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if(segue.Identifier == "toShowPostView")             {                 var postCommentView = (PublicarPostViewController)segue.DestinationViewController;                 postCommentView.PostPublicadoDelegate = this;                 postCommentView.setInfoPublicacion(miembro);             }              else if(segue.Identifier == "comentar")             {
				var CommentView = (comentarTableView)segue.DestinationViewController;
                CommentView.currentPost = CurrentPost;                 CommentView.currentPostImage = currentPostImage;                 CommentView.currentProfileImage = currentProfileImage;                 //CommentView.BackWindowDelegate = this;             }             else if(segue.Identifier == "toShowImageFromPost")             {                 var ImageView = (DetailCommentImage)segue.DestinationViewController;                 ImageView.ImagenPost = (UIImageView)sender;             }
        }          private void WillDisplay(int Row)         {             int LastRow = allPosts.Count - 1;             if ((Row == LastRow))             {                 BTProgressHUD.Dismiss();
            }         }          private void CargarInfo()         {             try             {                 if (InternetConectionHelper.VerificarConexion())                 {                     allPosts = new Controllers.EscritorioController().GetMuroPosts(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));                      foreach (PostModel currentPost in allPosts)                     {                         allPostImages.Add(ImageGallery.LoadImage(currentPost.Publicacion_Imagen_Ruta));                         allProfileImages.Add(ImageGallery.LoadImage(currentPost.Usuario_Fotografia_Ruta));                     }                     miembro = new MiembrosController().GetMemberName(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));                }                 else                 {                     this.btnScanQr.Title = "";                     this.btnScanQr.Enabled = false;                     isShowInformation = false;                     existeConeccion = false;                 }             }             catch(Exception e)             {                 SlackLogs.SendMessage(e.Message);             }                     } 
        partial void btnToScanQr_TouchUpInside(UIBarButtonItem sender)
        {
            this.PerformSegue("toScanQr", sender);
        } 
    }      partial class EscritorioController: PostPublicadoDel     {         public async void PostPublicado()         {             BTProgressHUD.Show(status: "Cargando Comentarios");             await Task.Delay(2000);             this.CargarInfo();             this.TableView.ReloadData();         }     }      /*partial class EscritorioController: BackWindow     {         public async void BackWindow()         {             BTProgressHUD.Show(status: "Cargando Comentarios");             await Task.Delay(2000);             //this.CargarInfo();         }     }*/ } 