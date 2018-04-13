using System; using UIKit; using WorklabsMx.iOS.Helpers; using WorklabsMx.Models; using System.Collections.Generic; using WorklabsMx.Controllers; using BigTed; using WorklabsMx.Helpers; using System.Threading.Tasks; using Foundation; using SWRevealViewControllerBinding;  namespace WorklabsMx.iOS {     public partial class EscritorioController : UITableViewController
    {
        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Post";         const string IdentificadorCeldaImagenPost = "PostImage";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoPublicacion = 223;
        const int TamañoHeader = 126;
        const int TamañoMensajeNoInfo = 500;

        bool isShowInformation = false;
        bool existeConeccion = true;
         List<PostModel> allPosts = new List<PostModel>();                UsuarioModel ListUser = new UsuarioModel();          PostModel CurrentPost = new PostModel();         UIImage currentProfileImage = new UIImage();         UIImage currentPostImage = new UIImage();         UIImageView ImagenPerfil;          public List<ItemsMenu> tableItems = new List<ItemsMenu>();          List<UsuarioModel> UsuariosLikes = new List<UsuarioModel>();          float withImage;         int Contador; 
        public EscritorioController(IntPtr handle) : base(handle)         {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();             Contador = 4;             RefreshControl = new UIRefreshControl();             RefreshControl.AddTarget(HandleValueChanged, UIControlEvent.ValueChanged);             await MenuHelper.GetMuroPosts();             allPosts = MenuHelper.AllPost;             TableView.ReloadData();             this.TableView.BeginUpdates();             this.TableView.EndUpdates();             await MenuHelper.FillTable();              withImage = float.Parse(UIScreen.MainScreen.Bounds.Width.ToString());             UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;             var Tap = new UITapGestureRecognizer(this.Tapped);             this.View.AddGestureRecognizer(Tap);         }

        public override void ViewWillAppear(bool animated)
        {             base.ViewWillAppear(animated);           
        }          void HandleValueChanged(object sender, EventArgs e)         {             this.GetData();         }          public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }          public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }          async void GetData()         {             RefreshControl.BeginRefreshing();              await MenuHelper.GetMuroPosts();             allPosts = MenuHelper.AllPost;             TableView.ReloadData();             this.TableView.BeginUpdates();             this.TableView.EndUpdates();             await MenuHelper.FillTable();
            if (RefreshControl != null && RefreshControl.Refreshing)
                RefreshControl.EndRefreshing();
        }          public override UIView GetViewForHeader(UITableView tableView, nint section)
        {             var headerCell = (EscritorioHeaderCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);             headerCell.UpdateCell();             headerCell.EventosHeaderDelegate = this;             this.ImagenPerfil = headerCell.getImagenPerfil();             StyleHelper.Style(headerCell.Layer);
            return headerCell.ContentView;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }
         
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (allPosts.Count > 0 /*&& allProfileImages.Count > 0 && allPostImages.Count > 0*/)
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
                var current = allPosts[indexPath.Row];                 if ((current.Publicacion_Imagen_Ruta != null && current.Publicacion_Imagen_Ruta != "") && (current.Publicacion_Imagen != null && current.Publicacion_Imagen != ""))                 {                     var currentImagePostCell = (ComentariosBodyImageCell)tableView.DequeueReusableCell(IdentificadorCeldaImagenPost, indexPath);                     currentImagePostCell.UpdateCell(current);                     currentImagePostCell.EventosComentariosDelegate = this;                     return currentImagePostCell;                 }                 else                 {                     var currentPostCell = (ComentariosBodyCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);                     currentPostCell.UpdateCell(current);                     currentPostCell.EventosComentariosBodyDel = this;                     return currentPostCell;                 }              
            }
            else
            {
                var noPostCell = (NoComentsCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }           public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if(segue.Identifier == "toShowPostView")             {                 var postCommentView = (PublicarPostViewController)segue.DestinationViewController;                 postCommentView.PostPublicadoDelegate = this;             }              else if(segue.Identifier == "comentar")             {
                var CommentView = (comentarTableView)segue.DestinationViewController;
                CommentView.currentPost = CurrentPost;             }             else if(segue.Identifier == "toShowImageFromPost")             {                 var ImageView = (DetailCommentImage)segue.DestinationViewController;                 ImageView.ImagenPost = (UIImageView)sender;             }              else if(segue.Identifier == "DetallarPerfil")             {                 var PerfilView = (PerfilesTableViewController)segue.DestinationViewController;                 PerfilView.FromMenu = false;                 if (MenuHelper.Usuario.Usuario_Id == ListUser.Usuario_Id && MenuHelper.Usuario.Usuario_Tipo == ListUser.Usuario_Tipo)                 {                     PerfilView.InfoPersonal = true;                 }                 else                 {                     PerfilView.InfoPersonal = false;                 }                 var usuario = new UsuariosController().GetMemberData(ListUser.Usuario_Id, ListUser.Usuario_Tipo);                 PerfilView.Miembro = usuario;             }             else if (segue.Identifier == "VistaLikes")             {                 var LikesView = (VistaLikes)segue.DestinationViewController;                 LikesView.UsuariosLikes = this.UsuariosLikes;             }
        }

        partial void Menu_Touch(UIBarButtonItem sender)
        {             this.View.EndEditing(true);
            this.RevealViewController().RevealToggleAnimated(true);             View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }          private void Tapped(UITapGestureRecognizer Recognizer)         {             this.View.EndEditing(true);         }     }      partial class EscritorioController: PostPublicadoDel     {         public async void PostPublicado()         {             BTProgressHUD.Show("");             await MenuHelper.GetMuroPosts();             allPosts = MenuHelper.AllPost;             TableView.ReloadData();             this.TableView.BeginUpdates();             this.TableView.EndUpdates();             BTProgressHUD.Dismiss();         }     }       partial class EscritorioController: EventosComentarios     {         public void MostrarImagenEnGrande(UIImageView imgPublicacion)         {             PerformSegue("toShowImageFromPost", imgPublicacion);         }         public void ComentarPost(PostModel PostLocal)         {             CurrentPost = PostLocal;
            BTProgressHUD.Show("");             this.PerformSegue("comentar", null);         }         public void InfoUserPost(UsuarioModel listaUser)         {             ListUser = listaUser;
            this.PerformSegue("DetallarPerfil", null);         }          public void EnviarActions(UIAlertController actionSheetAlert)         {             UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;             if (presentationPopover != null)             {                 presentationPopover.SourceView = this.View;                 presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;             }             this.PresentViewController(actionSheetAlert, true, null);         }          public async void ActualizaTabla()         {             await MenuHelper.GetMuroPosts();             allPosts = MenuHelper.AllPost;             TableView.ReloadData();             this.TableView.BeginUpdates();             this.TableView.EndUpdates();         }          public void UpdateRows()         {             if(this.Contador > 0)             {                 Contador = Contador - 1;                 System.Threading.Thread.Sleep(500);                 this.TableView.ReloadData();                 this.TableView.BeginUpdates();                 this.TableView.EndUpdates();             }          }          public void LikePresionado(List<UsuarioModel> UsuariosLikes)         {             this.UsuariosLikes = UsuariosLikes;             this.PerformSegue("VistaLikes", null);         }     }      partial class EscritorioController : EventosComentariosBody     {         public void ComentarPosts(PostModel PostLocal)         {             CurrentPost = PostLocal;             BTProgressHUD.Show("");             this.PerformSegue("comentar", null);             BTProgressHUD.Dismiss();         }         public void InfoUserPosts(UsuarioModel listaUser)         {             ListUser = listaUser;             this.PerformSegue("DetallarPerfil", null);                     }          public void EnviarAction(UIAlertController actionSheetAlert)         {             UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;             if (presentationPopover != null)             {                 presentationPopover.SourceView = this.View;                 presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;             }             this.PresentViewController(actionSheetAlert, true, null);         }          public async void ActualizarTabla()         {             await MenuHelper.GetMuroPosts();             allPosts = MenuHelper.AllPost;             TableView.ReloadData();             this.TableView.BeginUpdates();             this.TableView.EndUpdates();         }          public void LikeImagenPresionado(List<UsuarioModel> UsuariosLikes)         {             this.UsuariosLikes = UsuariosLikes;             this.PerformSegue("VistaLikes", null);         }       }      partial class EscritorioController : EventosHeader     {         public async void Buscando(string Texto)         {             await Task.Run(() =>             {
                string TextoBuscar = Texto;
                List<PostModel> SearchPost = new List<PostModel>();
                 allPosts = MenuHelper.AllPost;
               

                if (TextoBuscar != "")
                {
                    if (allPosts.FindAll(x => x.Publicacion_Contenido.Contains(TextoBuscar)) != null)
                    {
                        foreach (PostModel post in allPosts.FindAll(x => x.Publicacion_Contenido.Contains(TextoBuscar)))
                        {
                            if (SearchPost.Contains(post) == false)
                            {
                                SearchPost.Add(post);
                            }

                        }
                    }
                    if (allPosts.FindAll(x => x.Usuario.Usuario_Nombre.Contains(TextoBuscar)) != null)
                    {
                        foreach (PostModel post in allPosts.FindAll(x => x.Usuario.Usuario_Nombre.Contains(TextoBuscar)))
                        {
                            if (SearchPost.Contains(post) == false)
                            {
                                SearchPost.Add(post);
                            }

                        }
                    }
                    if (allPosts.FindAll(x => x.Usuario.Usuario_Puesto.Contains(TextoBuscar)) != null)
                    {
                        foreach (PostModel post in allPosts.FindAll(x => x.Usuario.Usuario_Puesto.Contains(TextoBuscar)))
                        {
                            if (SearchPost.Contains(post) == false)
                            {
                                SearchPost.Add(post);
                            }

                        }
                    }
                    this.allPosts = SearchPost;
                }             });              this.TableView.ReloadData();         }     }  } 