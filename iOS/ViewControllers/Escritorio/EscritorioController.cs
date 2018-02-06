using System; using UIKit; using WorklabsMx.iOS.Helpers; using WorklabsMx.Models; using System.Collections.Generic; using WorklabsMx.Controllers; using BigTed; using WorklabsMx.Helpers; using System.Threading.Tasks; using System.Threading; using Foundation; using SWRevealViewControllerBinding;  namespace WorklabsMx.iOS {     public partial class EscritorioController : UITableViewController
    {
        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Post";         const string IdentificadorCeldaImagenPost = "PostImage";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoPublicacion = 223;
        const int TamañoHeader = 126;
        const int TamañoMensajeNoInfo = 500;

        bool isShowInformation = false;
        bool existeConeccion = true;
         List<PostModel> allPosts = new List<PostModel>();          List<UIImage> allProfileImages = new List<UIImage>();         List<UIImage> allPostImages = new List<UIImage>();         List<string> miembro;          List<string> ListUser = new List<string>();          PostModel CurrentPost = new PostModel();         UIImage currentProfileImage = new UIImage();         UIImage currentPostImage = new UIImage();         UIImageView ImagenPerfil;          string upload_image_path;  
        public EscritorioController(IntPtr handle) : base(handle)         {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();             RefreshControl = new UIRefreshControl();             RefreshControl.AddTarget(HandleValueChanged, UIControlEvent.ValueChanged);                         UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;             upload_image_path = new ConfigurationsController().GetListConfiguraciones().Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PUBLICACIONES").Parametro_Varchar_1;                         var Tap = new UITapGestureRecognizer(this.Tapped);             this.View.AddGestureRecognizer(Tap);  
		}

        public override async void ViewWillAppear(bool animated)
        {             base.ViewWillAppear(animated);             this.CargarMiembro();             BTProgressHUD.Show("Cargando publicaciones");             await CargarInfo();             TableView.ReloadData();             this.TableView.BeginUpdates();             this.CargarImagenes();             this.TableView.EndUpdates();             BTProgressHUD.Dismiss();
        }          void HandleValueChanged(object sender, EventArgs e)         {             this.GetData();         }          public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }          public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }          async void GetData()         {                  RefreshControl.BeginRefreshing();
            await CargarInfo();
            TableView.ReloadData();
            TableView.BeginUpdates();             TableView.EndUpdates();
            if (RefreshControl != null && RefreshControl.Refreshing)
                RefreshControl.EndRefreshing();

        }          public override UIView GetViewForHeader(UITableView tableView, nint section)
        {             var headerCell = (EscritorioHeaderCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);             headerCell.UpdateCell(miembro);             headerCell.EventosHeaderDelegate = this;             this.ImagenPerfil = headerCell.getImagenPerfil();             StyleHelper.Style(headerCell.Layer);
            return headerCell.ContentView;
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

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var current = allPosts[indexPath.Row];
                var currentImageProfile = allProfileImages[indexPath.Row];                 var currentImagePost = allPostImages[indexPath.Row];                 if (currentImagePost != null)                 {                     var currentImagePostCell = (ComentariosBodyImageCell)tableView.DequeueReusableCell(IdentificadorCeldaImagenPost, indexPath);                     currentImagePostCell.UpdateCell(current, currentImageProfile, currentImagePost);                     currentImagePostCell.EventosComentariosDelegate = this;                     this.WillDisplay(indexPath.Row);                     return currentImagePostCell;                 }                 else                 {                     var currentPostCell = (ComentariosBodyCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);                     currentPostCell.UpdateCell(current, currentImageProfile);                     currentPostCell.EventosComentariosBodyDel = this;                     this.WillDisplay(indexPath.Row);                     return currentPostCell;                 }                
            }
            else
            {                 BTProgressHUD.Dismiss();
                var noPostCell = (NoComentsCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }          public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if(segue.Identifier == "toShowPostView")             {                 var postCommentView = (PublicarPostViewController)segue.DestinationViewController;                 postCommentView.PostPublicadoDelegate = this;                 postCommentView.setInfoPublicacion(miembro);             }              else if(segue.Identifier == "comentar")             {
				var CommentView = (comentarTableView)segue.DestinationViewController;
                CommentView.currentPost = CurrentPost;                 CommentView.currentPostImage = currentPostImage;                 CommentView.currentProfileImage = currentProfileImage;             }             else if(segue.Identifier == "toShowImageFromPost")             {                 var ImageView = (DetailCommentImage)segue.DestinationViewController;                 ImageView.ImagenPost = (UIImageView)sender;             }              else if(segue.Identifier == "DetallarPerfil")             {                 var PerfilView = (PerfilesTableViewController)segue.DestinationViewController;                 PerfilView.ListUser = ListUser;             }
        }          private void WillDisplay(int Row)         {             int LastRow = allPosts.Count - 1;             if ((Row == LastRow))             {                 BTProgressHUD.Dismiss();
            }         }          private void CargarImagenes()         {             if (InternetConectionHelper.VerificarConexion())             {                 if (allPosts.Count != 0)                 {                     foreach (PostModel currentPost in allPosts)                     {                         byte[] imageBytes = null;//new UploadImages().DownloadFileFTP(currentPost.Publicacion_Imagen, upload_image_path);                         if (imageBytes != null)                         {                             var data = NSData.FromArray(imageBytes);                             var uiimage = UIImage.LoadFromData(data);                             var porcentajeWith = ((float.Parse(UIScreen.MainScreen.Bounds.Width.ToString()) * 100) / uiimage.CGImage.Height);                             var HeightImage = uiimage.CGImage.Height * (porcentajeWith / 100);                             var ReescalImage = ImageHelper.ResizeUIImage(uiimage, float.Parse(UIScreen.MainScreen.Bounds.Width.ToString()), HeightImage);                             allPostImages.Add(ReescalImage);                         }                         else                         {                             allPostImages.Add(null);                         }                         allProfileImages.Add(ImageGallery.LoadImage(currentPost.Usuario.Usuario_Fotografia) ?? UIImage.FromBundle("ProfileImage"));                     }                 }             }          }          private void CargarMiembro()         {             if (InternetConectionHelper.VerificarConexion())             {                 miembro = new UsuariosController().GetMemberName(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));             }
        }          async Task CargarInfo()         {                          await Task.Delay(50);             try             {                 if (InternetConectionHelper.VerificarConexion())                 {                                          allPosts = new Controllers.EscritorioController().GetMuroPosts(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));                      if (allPosts.Count == 0)                     {
                        isShowInformation = false;                         existeConeccion = true;
                    }                                    }                 else                 {                     isShowInformation = false;                     existeConeccion = false;                 }             }             catch(Exception e)             {                 SlackLogs.SendMessage(e.Message);             }                     } 

        partial void Menu_Touch(UIBarButtonItem sender)
        {             this.View.EndEditing(true);
            this.RevealViewController().RevealToggleAnimated(true);             View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }          private void Tapped(UITapGestureRecognizer Recognizer)         {             this.View.EndEditing(true);         }     }      partial class EscritorioController: PostPublicadoDel     {         public async void PostPublicado()         {             BTProgressHUD.Show("Cargando Comentarios");             await Task.Delay(50);             await CargarInfo();             TableView.ReloadData();             this.CargarMiembro();             this.TableView.BeginUpdates();             this.CargarImagenes();             this.TableView.EndUpdates();             BTProgressHUD.Dismiss();          }     }       partial class EscritorioController: EventosComentarios     {         public void MostrarImagenEnGrande(UIImageView imgPublicacion)         {             PerformSegue("toShowImageFromPost", imgPublicacion);         }         public async void ComentarPost(PostModel PostLocal)         {             CurrentPost = PostLocal;
            BTProgressHUD.Show(status: "Cargando Comentarios");
            await Task.Delay(50);
            currentProfileImage = ImageGallery.LoadImage(CurrentPost.Usuario.Usuario_Fotografia);
            currentPostImage = ImageGallery.LoadImage(CurrentPost.Publicacion_Imagen_Ruta);
            this.PerformSegue("comentar", null);         }         public void InfoUserPost(List<String> listaUser)         {             ListUser = listaUser;
            this.PerformSegue("DetallarPerfil", null);         }     }      partial class EscritorioController : EventosComentariosBody     {         public async void ComentarPosts(PostModel PostLocal)         {             CurrentPost = PostLocal;             BTProgressHUD.Show(status: "Cargando Comentarios");             await Task.Delay(50);             currentProfileImage = ImageGallery.LoadImage(CurrentPost.Usuario.Usuario_Fotografia);             currentPostImage = ImageGallery.LoadImage(CurrentPost.Publicacion_Imagen_Ruta);             this.PerformSegue("comentar", null);             BTProgressHUD.Dismiss();         }         public void InfoUserPosts(List<String> listaUser)         {             ListUser = listaUser;             //this.PerformSegue("DetallarPerfil", null);         }     }      partial class EscritorioController : EventosHeader     {         public async void Buscando(string Texto)         {             await Task.Delay(50);             string TextoBuscar = Texto;             List<PostModel> SearchPost = new List<PostModel>();              if (InternetConectionHelper.VerificarConexion())             {                 allPosts = new Controllers.EscritorioController().GetMuroPosts(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));             }              if (TextoBuscar != "")             {                 if (allPosts.FindAll(x => x.Publicacion_Contenido.Contains(TextoBuscar)) != null)                 {                     foreach (PostModel post in allPosts.FindAll(x => x.Publicacion_Contenido.Contains(TextoBuscar)))                     {                         if (SearchPost.Contains(post) == false)                         {                             SearchPost.Add(post);                         }                      }                 }                 if (allPosts.FindAll(x => x.Usuario.Usuario_Nombre.Contains(TextoBuscar)) != null)                 {                     foreach (PostModel post in allPosts.FindAll(x => x.Usuario.Usuario_Nombre.Contains(TextoBuscar)))                     {                         if (SearchPost.Contains(post) == false)                         {                             SearchPost.Add(post);                         }                      }                 }                 if (allPosts.FindAll(x => x.Usuario.Usuario_Puesto.Contains(TextoBuscar)) != null)                 {                     foreach (PostModel post in allPosts.FindAll(x => x.Usuario.Usuario_Puesto.Contains(TextoBuscar)))                     {                         if (SearchPost.Contains(post) == false)                         {                             SearchPost.Add(post);                         }                      }                 }                 this.allPosts = SearchPost;             }             this.TableView.ReloadData();         }     }  } 