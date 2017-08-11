using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using WorklabsMx.iOS.Styles;
using System.Collections.Generic;
using PerpetualEngine.Storage;
using System.Threading.Tasks;
using WorklabsMx.iOS.ViewElements;
using WorklabsMx.Helpers;

namespace WorklabsMx.iOS
{
    public partial class EscritorioController : UIViewController
    {
        UIView viewView;
        UIScrollView scrollView;
        UIImageView imagen;
        int totalSize = 0;
        static int currentPage = 0;
        ImageGallery selectImage;
        SimpleStorage storageLocal;
        UITextField txtPublish;
        bool endLine = false;
        List<PostCard> AllPost;
        int postNumber;
        public EscritorioController(IntPtr handle) : base(handle)
        {
            storageLocal = SimpleStorage.EditGroup("Login");
            AllPost = new List<PostCard>();
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.ClearsContextBeforeDrawing = true;
            #region Publicar
            viewView = new UIView(new CGRect(0, 50, UIScreen.MainScreen.Bounds.Width, 30));
            txtPublish = new STLTextField("Publica algo :)", 20)
            {
                Frame = new CGRect(5, 20, UIScreen.MainScreen.Bounds.Width - 120, 30)
            };
            viewView.Add(txtPublish);
            UIButton btnPhoto = new STLButton(UIImage.FromBundle("ic_attach_file"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 140, 20, 30, 30),
                BackgroundColor = UIColor.FromRGBA(0, 0, 0, 0)
            };
            btnPhoto.TouchUpInside += BtnPhoto_TouchUpInside;
            viewView.Add(btnPhoto);

            UIButton btnPublicar = new STLButton("Publicar")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 110, 20, 100, 30)
            };
            btnPublicar.TouchUpInside += BtnPublicar_TouchUpInside;
            viewView.Add(btnPublicar);

            View.AddSubview(viewView);
            #endregion
            #region Acceso

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

            #endregion
            #region Posts
            scrollView = new UIScrollView(new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
            await this.AddPostsAsync();

            #endregion

        }
        /// <summary>
        /// Agrega a la pantalla los posts
        /// </summary>
        private async Task AddPostsAsync()
        {

            List<PostModel> posts = new Controllers.EscritorioController().GetMuroPosts(currentPage);
            if (posts.Count > 0)
            {
                endLine = (posts.Count < 5);
                foreach (PostModel post in posts)
                {
                    AllPost.Add(new PostCard(post)
                    {
                        Frame = new CGRect(0, totalSize, UIScreen.MainScreen.Bounds.Width, 140)
                    });
                    AllPost[postNumber].lblNombre.TouchUpInside += (sender, e) =>
                    {
                        try
                        {
                            PerfilController perfilController = (PerfilController)Storyboard.InstantiateViewController("PerfilIndividualController");
                            perfilController.Tipo = post.Tipo;
                            perfilController.Usuario = post.MIEMBRO_ID;
                            NavigationController.PushViewController(perfilController, true);
                            ((UIButton)sender).BackgroundColor = UIColor.Clear;
                        }
                        catch (Exception ex)
                        {
                            SlackLogs.SendMessage(ex.Message);
                        }
                    };
                    totalSize += AllPost[postNumber].totalSize;
                    scrollView.AddSubview(AllPost[postNumber]);
                    UITextField txtComentario = new STLTextField("Escribe un comentario", 215 + totalSize)
                    {
                        Frame = new CGRect(5, 140 + totalSize - (AllPost[postNumber].PostComments.Count * 60), UIScreen.MainScreen.Bounds.Width - 50, 30)
                    };
                    scrollView.Add(txtComentario);

                    UIButton btnComentar = new STLButton(UIImage.FromBundle("ic_send"))
                    {
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 140 + totalSize - (AllPost[postNumber].PostComments.Count * 60), 30, 30),
                        BackgroundColor = UIColor.LightGray
                    };
                    btnComentar.Layer.CornerRadius = 15;
                    btnComentar.TouchUpInside += async (sender, e) =>
                    {
                        if (new Controllers.EscritorioController().CommentPost(post.POST_ID, storageLocal.Get("Usuario_Id"), txtComentario.Text))
                        {
                            nfloat scrollPosition = scrollView.ContentOffset.Y;
                            txtComentario.Text = "";
                            /*for (int i = postNumber; i < AllPost.Count; i++)
                            {
                                AllPost[i].Frame = new CGRect(0, totalSize + 60, UIScreen.MainScreen.Bounds.Width, 140);
                            }*/
                            await AddPostsAsync();
                            scrollView.ContentOffset = new CGPoint(0, scrollPosition);
                        }
                    };
                    scrollView.Add(btnComentar);

                    #region Comentarios
                    //await AddCommentsPostAsync(post.POST_ID);
                    #endregion
                    totalSize += 180;
                    ++postNumber;
                }
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 100 + totalSize);

                scrollView.Scrolled += ScrollView_Scrolled;
                View.AddSubview(scrollView);
            }
            else
            {
                endLine = true;
                Console.WriteLine("No more elements");
            }
        }



        void BtnPhoto_TouchUpInside(object sender, EventArgs e)
        {
            viewView.Frame = new CGRect(5, 50, UIScreen.MainScreen.Bounds.Width, 100);
            UIImagePickerController imagePicker = new UIImagePickerController();
            imagen = new STLImageView(65, "");
            imagen.Image.Scale(new CGSize(50, 50), 0);
            viewView.Add(imagen);
            selectImage = new ImageGallery(imagePicker, imagen);
            this.PresentViewController(imagePicker, true, () => { });
            scrollView.Frame = new CGRect(0, 150, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height);
        }

        async void BtnPublicar_TouchUpInside(object sender, EventArgs e)
        {
            if (imagen != null)
                imagen.Hidden = true;
            if (new WorklabsMx.Controllers.EscritorioController().SetPost(storageLocal.Get("Usuario_Id"), null, txtPublish.Text, "", imagen?.Image.AsPNG().ToArray()))
            {
                scrollView.RemoveFromSuperview();
                totalSize = 0;
                currentPage = 0;
                scrollView = new UIScrollView(new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
                AllPost.Reverse();
                await AddPostsAsync();
                txtPublish.Text = "";
            }
        }

        async void ScrollView_Scrolled(object sender, EventArgs e)
        {
            if (((UIScrollView)sender).ContentOffset.Y > totalSize - 1000 && !endLine)
            {
                currentPage += 5;
                await this.AddPostsAsync();
            }
        }
    }
}