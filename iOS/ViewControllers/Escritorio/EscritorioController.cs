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
         List<PostModel> allPosts = new List<PostModel>();          List<UIImage> allProfileImages = new List<UIImage>();         List<UIImage> allPostImages = new List<UIImage>();          UsuarioModel ListUser = new UsuarioModel();          PostModel CurrentPost = new PostModel();         UIImage currentProfileImage = new UIImage();         UIImage currentPostImage = new UIImage();         UIImageView ImagenPerfil;          public List<ItemsMenu> tableItems = new List<ItemsMenu>();          float withImage; 
        public EscritorioController(IntPtr handle) : base(handle)         {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();             withImage = float.Parse(UIScreen.MainScreen.Bounds.Width.ToString());             BTProgressHUD.Show("Cargando publicaciones");             await MenuHelper.GetListConfiguraciones();              RefreshControl = new UIRefreshControl();             RefreshControl.AddTarget(HandleValueChanged, UIControlEvent.ValueChanged);             UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;             var Tap = new UITapGestureRecognizer(this.Tapped);             this.View.AddGestureRecognizer(Tap);             await MenuHelper.FillTable();             await MenuHelper.FillUserInfo();             await MenuHelper.GetSucursales();             await MenuHelper.GetUsuarioInfo();             BTProgressHUD.Dismiss();
		}

        public override async void ViewWillAppear(bool animated)
        {             base.ViewWillAppear(animated);             await CargarInfo();             TableView.ReloadData();             this.TableView.BeginUpdates();             this.TableView.EndUpdates();
        }          void HandleValueChanged(object sender, EventArgs e)         {             this.GetData();         }          public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }          public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }          async void GetData()         {             RefreshControl.BeginRefreshing();
            await CargarInfo();             TableView.ReloadData();             this.TableView.BeginUpdates();             this.TableView.EndUpdates();
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
                var currentImageProfile = allProfileImages[indexPath.Row];                 var currentImagePost = allPostImages[indexPath.Row];                 if (currentImagePost != null)                 {                     var currentImagePostCell = (ComentariosBodyImageCell)tableView.DequeueReusableCell(IdentificadorCeldaImagenPost, indexPath);                     currentImagePostCell.UpdateCell(current, currentImageProfile, currentImagePost);                     currentImagePostCell.EventosComentariosDelegate = this;                     return currentImagePostCell;                 }                 else                 {                     var currentPostCell = (ComentariosBodyCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);                     currentPostCell.UpdateCell(current, currentImageProfile);                     currentPostCell.EventosComentariosBodyDel = this;                     return currentPostCell;                 }                
            }
            else
            {
                var noPostCell = (NoComentsCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }          public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if(segue.Identifier == "toShowPostView")             {                 var postCommentView = (PublicarPostViewController)segue.DestinationViewController;                 postCommentView.PostPublicadoDelegate = this;             }              else if(segue.Identifier == "comentar")             {
				var CommentView = (comentarTableView)segue.DestinationViewController;
                CommentView.currentPost = CurrentPost;                 CommentView.currentPostImage = currentPostImage;                 CommentView.currentProfileImage = currentProfileImage;             }             else if(segue.Identifier == "toShowImageFromPost")             {                 var ImageView = (DetailCommentImage)segue.DestinationViewController;                 ImageView.ImagenPost = (UIImageView)sender;             }              else if(segue.Identifier == "DetallarPerfil")             {                 var PerfilView = (PerfilesTableViewController)segue.DestinationViewController;                 if (MenuHelper.Usuario.Usuario_Id == ListUser.Usuario_Id && MenuHelper.Usuario.Usuario_Tipo == ListUser.Usuario_Tipo)                 {                     PerfilView.InfoPersonal = true;                 }                 else                 {                     PerfilView.InfoPersonal = false;                 }                 var usuario = new UsuariosController().GetMemberDataAsync(ListUser.Usuario_Id, ListUser.Usuario_Tipo);                 PerfilView.Miembro = usuario;             }
        }           async Task CargarInfo()         {

            await Task.Run(() =>             {
                try
                {
                    if (InternetConectionHelper.VerificarConexion())
                    {

                        allPosts = new Controllers.EscritorioController().GetMuroPosts(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
                         if (allPosts != null)                         {                             if (allPosts.Count == 0)                             {                                 isShowInformation = false;                                 existeConeccion = true;                             }                             else                             {                                 allPostImages = new List<UIImage>();                                 allProfileImages = new List<UIImage>();                                 foreach (PostModel currentPost in allPosts)                                 {                                     if (currentPost.Publicacion_Imagen_Post != null)                                     {                                         var data = NSData.FromArray(currentPost.Publicacion_Imagen_Post);                                         var uiimage = UIImage.LoadFromData(data);                                         var porcentajeWith = ((withImage * 100) / uiimage.CGImage.Height);                                         var HeightImage = uiimage.CGImage.Height * (porcentajeWith / 100);                                         var ReescalImage = ImageHelper.ResizeUIImage(uiimage, withImage, HeightImage);                                         allPostImages.Add(ReescalImage);                                     }                                     else                                     {                                         allPostImages.Add(null);                                     }                                      if (currentPost.Usuario.Usuario_Fotografia_Perfil != null)                                     {                                         var data = NSData.FromArray(currentPost.Usuario.Usuario_Fotografia_Perfil);                                         var uiimage = UIImage.LoadFromData(data);                                         allProfileImages.Add(uiimage);                                     }                                     else                                     {                                         allProfileImages.Add(UIImage.FromBundle("ProfileImage"));                                     }                                 }                             }                         }                         else                         {                             isShowInformation = false;                             existeConeccion = true;                         }


                    }
                    else
                    {
                        isShowInformation = false;
                        existeConeccion = false;
                    }
                }
                catch (Exception e)
                {
                    SlackLogs.SendMessage(e.Message);
                }             });         }

        partial void Menu_Touch(UIBarButtonItem sender)
        {             this.View.EndEditing(true);
            this.RevealViewController().RevealToggleAnimated(true);             View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }          private void Tapped(UITapGestureRecognizer Recognizer)         {             this.View.EndEditing(true);         }     }      partial class EscritorioController: PostPublicadoDel     {         public async void PostPublicado()         {             BTProgressHUD.Show("Cargando Comentarios");             await CargarInfo();             TableView.ReloadData();             this.TableView.BeginUpdates();             this.TableView.EndUpdates();             BTProgressHUD.Dismiss();          }     }       partial class EscritorioController: EventosComentarios     {         public void MostrarImagenEnGrande(UIImageView imgPublicacion)         {             PerformSegue("toShowImageFromPost", imgPublicacion);         }         public async void ComentarPost(PostModel PostLocal)         {             CurrentPost = PostLocal;
            BTProgressHUD.Show(status: "Cargando Comentarios");
            await Task.Run(() =>             {
                currentProfileImage = ImageGallery.LoadImage(CurrentPost.Usuario.Usuario_Fotografia);
                currentPostImage = ImageGallery.LoadImage(CurrentPost.Publicacion_Imagen_Ruta);
                this.PerformSegue("comentar", null);             });         }         public void InfoUserPost(UsuarioModel listaUser)         {             ListUser = listaUser;
            this.PerformSegue("DetallarPerfil", null);         }          public void EnviarActions(UIAlertController actionSheetAlert)         {             UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;             if (presentationPopover != null)             {                 presentationPopover.SourceView = this.View;                 presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;             }             this.PresentViewController(actionSheetAlert, true, null);         }          public async void ActualizaTabla()         {             await CargarInfo();             TableView.ReloadData();             this.TableView.BeginUpdates();             this.TableView.EndUpdates();         }     }      partial class EscritorioController : EventosComentariosBody     {         public async void ComentarPosts(PostModel PostLocal)         {             CurrentPost = PostLocal;             BTProgressHUD.Show(status: "Cargando Comentarios");             await Task.Run(() =>             {
                currentProfileImage = ImageGallery.LoadImage(CurrentPost.Usuario.Usuario_Fotografia);
                currentPostImage = ImageGallery.LoadImage(CurrentPost.Publicacion_Imagen_Ruta);             });             this.PerformSegue("comentar", null);             BTProgressHUD.Dismiss();         }         public void InfoUserPosts(UsuarioModel listaUser)         {             ListUser = listaUser;             this.PerformSegue("DetallarPerfil", null);                     }          public void EnviarAction(UIAlertController actionSheetAlert)         {             UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;             if (presentationPopover != null)             {                 presentationPopover.SourceView = this.View;                 presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;             }             this.PresentViewController(actionSheetAlert, true, null);         }          public async void ActualizarTabla()         {             await CargarInfo();             TableView.ReloadData();             this.TableView.BeginUpdates();             this.TableView.EndUpdates();          }       }      partial class EscritorioController : EventosHeader     {         public async void Buscando(string Texto)         {             await Task.Run(() =>             {
                string TextoBuscar = Texto;
                List<PostModel> SearchPost = new List<PostModel>();

                if (InternetConectionHelper.VerificarConexion())
                {
                    allPosts = new Controllers.EscritorioController().GetMuroPosts(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
                }

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