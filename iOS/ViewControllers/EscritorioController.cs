using System; using UIKit; using WorklabsMx.iOS.Helpers; using WorklabsMx.Models; using System.Collections.Generic; using WorklabsMx.Controllers; using BigTed;  namespace WorklabsMx.iOS {     public partial class EscritorioController : UITableViewController //UIViewController
    {
        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Post";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoPublicacion = 190;
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
            base.ViewDidLoad();             currentPage = 0;             if (InternetConectionHelper.VerificarConexion())             {                 allPosts = new Controllers.EscritorioController().GetMuroPosts(currentPage);                 for (int Indice = 0; Indice < allPosts.Count; Indice++)                 {                     var like = new Controllers.EscritorioController().GetLikes(allPosts[Indice].POST_ID) + " LIKES";                     var PostImage = ImageGallery.LoadImage(allPosts[Indice].Miembro_Fotografia);                     Likes.Add(like);                     PostImages.Add(PostImage);                 }                 var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");                 miembro = new MiembrosController().GetMemberName(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));             }             else             {                 this.btnScanQr.Title = "";                 this.btnScanQr.Enabled = false;                 isShowInformation = false;                 existeConeccion = false;             }             BTProgressHUD.Dismiss();
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
                this.CurrentPost = currentPost;
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
        }  
        public override void WillDisplay(UITableView tableView, UITableViewCell cell, Foundation.NSIndexPath indexPath)         {
			
            if (tableView.ContentOffset.Y >= (tableView.ContentSize.Height - tableView.Frame.Size.Height))
			{                                  BTProgressHUD.Show();                 if (InternetConectionHelper.VerificarConexion())                 {
                    currentPage += 5;
                    posts = new Controllers.EscritorioController().GetMuroPosts(currentPage);
                    foreach (var post in posts)
                    {
                        allPosts.Add(post);                         var like = new Controllers.EscritorioController().GetLikes(post.POST_ID) + " LIKES";                         var PostImage = ImageGallery.LoadImage(post.Miembro_Fotografia);                         Likes.Add(like);                         PostImages.Add(PostImage);
                    }
                    this.TableView.ReloadData();                     BTProgressHUD.Dismiss();
                }                 else                 {                     BTProgressHUD.Dismiss();                     new MessageDialog().SendToast("No tienes acceso a una conexión de Internet, intenta de nuevo");                 }
			}
        } 

        partial void btnToScanQr_TouchUpInside(UIBarButtonItem sender)
        {
            this.PerformSegue("toScanQr", sender);
        }

        /*         UIView viewView;         UIScrollView scrollView;         UIImageView imagen;         int postNumber, totalSize = 0;         static int currentPage = 0;         ImageGallery selectImage;         SimpleStorage storageLocal;         UITextField txtPublish;         bool endLine = false;         List<PostCard> AllPost;         public EscritorioController(IntPtr handle) : base(handle)         {             storageLocal = SimpleStorage.EditGroup("Login");             AllPost = new List<PostCard>();         }          public async override void ViewDidLoad()         {             base.ViewDidLoad();              if (InternetConectionHelper.VerificarConexion())             {                 this.VistaMensaje.Hidden = true;                 this.lblMensaje.Hidden = true;               View.ClearsContextBeforeDrawing = true;                 #region Publicar                viewView = new UIView(new CGRect(0, 50, UIScreen.MainScreen.Bounds.Width, 50));                 txtPublish = new STLTextField("Publica algo :)", 20)                {                   Frame = new CGRect(5, 20, UIScreen.MainScreen.Bounds.Width - 50, 30)                } ;                 viewView.Add(txtPublish);               UIButton btnPhoto = new STLButton(UIImage.FromBundle("ic_attach_file"))                 {                   Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 70, 20, 30, 30),                  BackgroundColor = UIColor.FromRGBA(0, 0, 0, 0)              } ;                 btnPhoto.TouchUpInside += BtnPhoto_TouchUpInside;               viewView.Add(btnPhoto);                 UIButton btnPublicar = new STLButton(UIImage.FromBundle("ic_send"))                 {                   Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 20, 30, 30)               } ;                 btnPublicar.TouchUpInside += BtnPublicar_TouchUpInside;                 viewView.Add(btnPublicar);                  View.AddSubview(viewView);              #endregion              #region Acceso                  this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_qr"), UIBarButtonItemStyle.Plain, (sender, e) =>               {                   UIActivityIndicatorView waiting = new UIActivityIndicatorView                   {                       Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 2, UIScreen.MainScreen.Bounds.Height / 2, 30, 30)                     } ;                     View.AddSubview(waiting);                   UIViewController controller = this.Storyboard.InstantiateViewController("AccesoController");                    controller.Title = "Control de Acceso";                     this.NavigationController.PushViewController(controller, true);                 } ), true);                 #endregion              #region Posts               scrollView = new UIScrollView(new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));                 await this.AddPostsAsync();                 #endregion              }  else {                 this.VistaMensaje.Hidden = false;                 this.lblMensaje.Hidden = false;                 this.NavigationItem.HidesBackButton = true;             }           }         /// <summary>         /// Agrega a la pantalla los posts         /// </summary>         private async Task AddPostsAsync()         {             List<PostModel> posts = new Controllers.EscritorioController().GetMuroPosts(currentPage);             if (posts.Count > 0)             {                 endLine = (posts.Count < 5);                 foreach (PostModel post in posts)                 {                     AllPost.Add(new PostCard(post, this)                     {                         Frame = new CGRect(0, totalSize, UIScreen.MainScreen.Bounds.Width, 140)                     });                     AllPost[postNumber].lblNombre.TouchUpInside += (sender, e) =>                     {                         try                         {                             PerfilController perfilController = (PerfilController)Storyboard.InstantiateViewController("PerfilIndividualController");                             perfilController.Tipo = post.Tipo;                             perfilController.Usuario = post.MIEMBRO_ID;                             perfilController.Title = "Perfil";                             NavigationController.PushViewController(perfilController, true);                             ((UIButton)sender).BackgroundColor = UIColor.Clear;                         }                         catch (Exception ex) { SlackLogs.SendMessage(ex.Message); }                     };                      AllPost[postNumber].btnDelete.TouchUpInside += (sender, e) =>                     {                         if (post.MIEMBRO_ID == storageLocal.Get("Usuario_Id") && post.Tipo == storageLocal.Get("Usuario_Tipo"))                         {                             new MessageDialog().SendConfirmation("Se eliminarál post", "Borrar post", async (obj) =>                             {                                 if (obj)                                     if (new Controllers.EscritorioController().OcultarPost(post.MIEMBRO_ID, post.POST_ID, 0))                                     {                                         new MessageDialog().SendToast("Post eliminado");                                         currentPage = 0;                                         await AddPostsAsync();                                     }                                     else                                         new MessageDialog().SendToast("Hubo un error, intente de nuevo");                             });                         }                         else                             new MessageDialog().SendConfirmation("¿esea reportar el post?", "Reportar post", (obj) =>                             {                                 if (obj)                                 {                                     ReporteController reporteController = (ReporteController)Storyboard.InstantiateViewController("ReporteController");                                     reporteController.post_id = post.POST_ID;                                     reporteController.Title = "Reportar Post";                                     NavigationController.PushViewController(reporteController, true);                                     ((UIButton)sender).BackgroundColor = UIColor.Clear;                                 }                             });                     };                      if (AllPost[postNumber].comentarioCount > 0)                         AllPost[postNumber].Frame = new CGRect(0, totalSize, UIScreen.MainScreen.Bounds.Width, 370);                      scrollView.AddSubview(AllPost[postNumber]);                     scrollView.BringSubviewToFront(AllPost[postNumber]);                     UITextField txtComentario = new STLTextField("Escribe un comentario", 215)                     {                         Frame = new CGRect(5, 140 + totalSize + (AllPost[postNumber].image ? 110 : 0), UIScreen.MainScreen.Bounds.Width - 50, 30)                     };                     scrollView.Add(txtComentario);                      UIButton btnComentar = new STLButton(UIImage.FromBundle("ic_send"))                     {                         Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 140 + totalSize + (AllPost[postNumber].image ? 110 : 0), 30, 30)                     };                     btnComentar.Layer.CornerRadius = 15;                     btnComentar.TouchUpInside += async (sender, e) =>                     {                         if (new Controllers.EscritorioController().CommentPost(post.POST_ID, storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"), txtComentario.Text))                         {                             nfloat scrollPosition = scrollView.ContentOffset.Y;                             txtComentario.Text = "";                             await AddPostsAsync();                             scrollView.ContentOffset = new CGPoint(0, scrollPosition);                         }                     };                     scrollView.Add(btnComentar);                     totalSize += AllPost[postNumber].totalSize;                     totalSize += 180;                     ++postNumber;                 }                 scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 100 + totalSize);                  scrollView.Scrolled += ScrollView_Scrolled;                 View.AddSubview(scrollView);                 View.BringSubviewToFront(scrollView);                 SVProgressHUD.Dismiss();             }             else             {                 SVProgressHUD.Dismiss();                 endLine = true;                 Console.WriteLine("No more elements");             }         }          void BtnPhoto_TouchUpInside(object sender, EventArgs e)         {             viewView.Frame = new CGRect(5, 50, UIScreen.MainScreen.Bounds.Width, 100);             UIImagePickerController imagePicker = new UIImagePickerController();             imagen = new STLImageView(65, "");             imagen.Image.Scale(new CGSize(50, 50), 0);             viewView.Add(imagen);             selectImage = new ImageGallery(imagePicker, imagen);             this.PresentViewController(imagePicker, true, () => { });             scrollView.Frame = new CGRect(0, 150, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height);         }          async void BtnPublicar_TouchUpInside(object sender, EventArgs e)         {             if (imagen != null)                 imagen.Hidden = true;             if (new Controllers.EscritorioController().SetPost(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"), txtPublish.Text, "", imagen?.Image.AsPNG().ToArray()))             {                 scrollView.RemoveFromSuperview();                 totalSize = 0;                 currentPage = 0;                 scrollView = new UIScrollView(new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));                 AllPost.Reverse();                 await AddPostsAsync();                 txtPublish.Text = "";             }         }          async void ScrollView_Scrolled(object sender, EventArgs e)         {             if (((UIScrollView)sender).ContentOffset.Y > totalSize - 1000 && !endLine)             {                 currentPage += 5;                 await this.AddPostsAsync();             }         }*/
    } } 