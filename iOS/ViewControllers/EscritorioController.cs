using Foundation;
using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using WorklabsMx.iOS.Styles;
using System.Collections.Generic;
using PerpetualEngine.Storage;
using System.Threading.Tasks;

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
        public EscritorioController(IntPtr handle) : base(handle)
        {
            storageLocal = SimpleStorage.EditGroup("Login");
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
            //var accesoView = new UIView(new CGRect(UIScreen.MainScreen.Bounds.Width - 75, UIScreen.MainScreen.Bounds.Height - 75, 200, 200));

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
            //View.AddSubview(accesoView);
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
            List<PostModel> posts = new WorklabsMx.Controllers.EscritorioController().GetMuroPosts(currentPage);
            if (posts.Count > 0)
            {
                endLine = (posts.Count < 5);
                foreach (PostModel post in posts)
                {
                    UIImageView pstImage = new UIImageView
                    {
                        Image = ImageGallery.LoadImage(post.Miembro_Fotografia),
                        Frame = new CGRect(10, 20 + totalSize, 50, 50)
                    };
                    pstImage.Layer.MasksToBounds = true;
                    pstImage.Layer.CornerRadius = 25;
                    scrollView.Add(pstImage);

                    scrollView.Add(new UILabel
                    {
                        Frame = new CGRect(65, 25 + totalSize, UIScreen.MainScreen.Bounds.Width, 20),
                        Text = post.Miembro_Nombre + " " + post.Miembro_Apellidos,
                        Font = UIFont.BoldSystemFontOfSize(16)
                    });
                    UILabel lblfecha = new STLLabel(post.POST_FECHA, 45 + totalSize, 12)
                    {
                        Frame = new CGRect(65, 35 + totalSize, UIScreen.MainScreen.Bounds.Width, 50)
                    };
                    scrollView.Add(lblfecha);

                    //Likes
                    UIButton btnLike = new STLButton(new WorklabsMx.Controllers.EscritorioController().GetLikes(post.POST_ID) + " Like(s)",UIImage.FromBundle("ic_thumb_up"))
                    {
                        Frame = new CGRect(10, 75 + totalSize, UIScreen.MainScreen.Bounds.Width - 100, 20),
                        Font = UIFont.SystemFontOfSize(10),
                        BackgroundColor = UIColor.White,

                    };
                    btnLike.TouchUpInside += (sender, e) =>
                    {
                        btnLike.BackgroundColor = UIColor.White;
                        if (new WorklabsMx.Controllers.EscritorioController().PostLike(post.POST_ID, SimpleStorage.EditGroup("Login").Get("Miembro_Id")))
                            btnLike.SetTitle(new WorklabsMx.Controllers.EscritorioController().GetLikes(post.POST_ID) + " Like(s)", UIControlState.Normal);
                    };
                    btnLike.TouchDown += (sender, e) =>
                    {
                        btnLike.BackgroundColor = UIColor.LightGray;

                    };
                    scrollView.Add(btnLike);

                    if (post.POST_FOTO_URL != "")
                    {
                        UIImageView imgPost = new STLImageView(110 + totalSize, post.POST_FOTO_URL)
                        {
                            Frame = new CGRect(10, 140 + totalSize, UIScreen.MainScreen.Bounds.Width - 100, 100)
                        };
                        scrollView.Add(imgPost);
                        totalSize += 160;
                    }

                    UILabel txtPost = new UILabel
                    {
                        Frame = new CGRect(10, 110 + totalSize, UIScreen.MainScreen.Bounds.Width - 10, 30),
                        Text = post.POST_CONTENIDO,
                        Font = UIFont.SystemFontOfSize(16),
                        LineBreakMode = UILineBreakMode.WordWrap,
                        Lines = 0
                    };
                    int postSize = 30 * Convert.ToInt32(Math.Floor(txtPost.IntrinsicContentSize.Width / (UIScreen.MainScreen.Bounds.Width - 10)));
                    txtPost.Frame = new CGRect(10, 110 + totalSize, UIScreen.MainScreen.Bounds.Width - 10, 30 + postSize);
                    scrollView.Add(txtPost);
                    totalSize += postSize;

                    UITextField txtComentario = new STLTextField("Escribe un comentario", 215 + totalSize)
                    {
                        Frame = new CGRect(5, 140 + totalSize, UIScreen.MainScreen.Bounds.Width - 50, 30)
                    };
                    scrollView.Add(txtComentario);

                    UIButton btnComentar = new STLButton(UIImage.FromBundle("ic_send"))
                    {
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 140 + totalSize, 30, 30),
                        BackgroundColor = UIColor.LightGray
                    };
                    btnComentar.Layer.CornerRadius = 15;
                    btnComentar.TouchUpInside += async (sender, e) =>
                    {
                        if (new WorklabsMx.Controllers.EscritorioController().CommentPost(post.POST_ID, storageLocal.Get("Miembro_Id"), txtComentario.Text))
                        {
                            nfloat scrollPosition = scrollView.ContentOffset.Y;
                            txtComentario.Text = "";
                            await AddPostsAsync();
                            scrollView.ContentOffset = new CGPoint(0, scrollPosition);
                        }
                    };
                    scrollView.Add(btnComentar);

                    #region Comentarios
                    await AddCommentsPostAsync(post.POST_ID);
                    #endregion
                    totalSize += 180;
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

        private async Task AddCommentsPostAsync(string post_id)
        {
            int commentSize = 0;
            UIScrollView scrollCommentView = new UIScrollView(new CGRect(0, 170 + totalSize, UIScreen.MainScreen.Bounds.Width, 100));
            List<ComentarioModel> comentarios = new WorklabsMx.Controllers.EscritorioController().GetComentariosPost(post_id);

            foreach (ComentarioModel comentario in comentarios)
            {
                UIImageView pstImage = new UIImageView
                {
                    Image = ImageGallery.LoadImage(comentario.Miembro_Fotografia),
                    Frame = new CGRect(10, 20 + commentSize, 20, 20)
                };
                pstImage.Layer.CornerRadius = 10;
                scrollCommentView.Add(pstImage);

                scrollCommentView.Add(new UILabel
                {
                    Frame = new CGRect(30, 20 + commentSize, UIScreen.MainScreen.Bounds.Width, 10),
                    Text = comentario.Nombre,
                    Font = UIFont.BoldSystemFontOfSize(10)
                });

                scrollCommentView.Add(new UILabel
                {
                    Frame = new CGRect(30, 30 + commentSize, UIScreen.MainScreen.Bounds.Width, 8),
                    Text = comentario.COMM_FECHA,
                    Font = UIFont.SystemFontOfSize(8)
                });

                UILabel txtPost = new UILabel
                {
                    Frame = new CGRect(10, 40 + commentSize, UIScreen.MainScreen.Bounds.Width - 10, 20),
                    Text = comentario.COMM_CONTENIDO,
                    Font = UIFont.SystemFontOfSize(12)
                };
                commentSize += 60;
                scrollCommentView.Add(txtPost);
            }
            scrollCommentView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 80);
            totalSize += commentSize;
            scrollView.Add(scrollCommentView);
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
            if (new WorklabsMx.Controllers.EscritorioController().SetPost(storageLocal.Get("Miembro_Id"), null, txtPublish.Text, "", imagen?.Image.AsPNG().ToArray()))
            {
                scrollView.RemoveFromSuperview();
                totalSize = 0;
                currentPage = 0;
                scrollView = new UIScrollView(new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
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
                //scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 100 + totalSize);
            }

        }
    }


}