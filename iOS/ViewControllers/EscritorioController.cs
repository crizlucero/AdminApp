using Foundation;
using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using WorklabsMx.iOS.Styles;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class EscritorioController : UIViewController
    {
        //UIImagePickerController imagePicker;
        //UIButton choosePhotoButton;
        //UIImageView imageView;
        //ImageGallery selectImage;
        UIView viewView;
        UIScrollView scrollView;
        UIImageView imagen;
        int totalSize = 0;
        static int currentPage = 0;
        ImageGallery selectImage;
        public EscritorioController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.ClearsContextBeforeDrawing = true;
            #region Publicar
            viewView = new UIView(new CGRect(0, 50, UIScreen.MainScreen.Bounds.Width, 30));
            UITextField txtPublish = new STLTextField("Publica algo :)", 20);
            txtPublish.Frame = new CGRect(5, 20, UIScreen.MainScreen.Bounds.Width - 120, 30);
            viewView.Add(txtPublish);
            UIButton btnPhoto = new STLButton("Seleccionar imagen");
            btnPhoto.Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 140, 20, 30, 30);
            btnPhoto.SetTitle("", UIControlState.Normal);
            btnPhoto.SetImage(UIImage.FromBundle("ic_attach_file"), UIControlState.Normal);
            btnPhoto.BackgroundColor = UIColor.FromRGBA(0, 0, 0, 0);
            btnPhoto.TouchUpInside += BtnPhoto_TouchUpInside;
            viewView.Add(btnPhoto);

            UIButton btnPublicar = new STLButton("Publicar")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 110, 20, 100, 30)
            };
            btnPublicar.TouchUpInside += BtnPublicar_TouchUpInside;
            viewView.Add(btnPublicar);

            View.Add(viewView);
            #endregion
            #region Posts
            scrollView = new UIScrollView(new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
            this.AddPosts();
            scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 100 + totalSize);
            View.Add(scrollView);
            #endregion
            #region Acceso
            var accesoView = new UIView(new CGRect(UIScreen.MainScreen.Bounds.Width - 75, UIScreen.MainScreen.Bounds.Height - 75, 200, 200));

            this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_qr"), UIBarButtonItemStyle.Plain, (sender, e) =>
            {
                UIActivityIndicatorView waiting = new UIActivityIndicatorView
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 2, UIScreen.MainScreen.Bounds.Height / 2, 30, 30)
                };
                View.Add(waiting);
                UIViewController controller = this.Storyboard.InstantiateViewController("AccesoController");
                controller.Title = "Control de Acceso";
                this.NavigationController.PushViewController(controller, true);
            }), true);

            scrollView.Scrolled += (sender, e) =>
            {
                Console.WriteLine(((UIScrollView)sender).ContentOffset.Y);
                Console.WriteLine(totalSize);
                if (((UIScrollView)sender).ContentOffset.Y > totalSize - 1000)
                {
                    ++currentPage;
                    this.AddPosts();
                    scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 100 + totalSize);
                }

            };


            #endregion
            View.Add(accesoView);
        }
        /// <summary>
        /// Agrega a la pantalla los posts
        /// </summary>
        private void AddPosts()
        {
            foreach (PostModel post in new WorklabsMx.Controllers.EscritorioController().GetMuroPosts(currentPage))
            {
                UIImageView pstImage = new UIImageView
                {
                    Image = ImageGallery.LoadImage(post.Miembro_Fotografia),
                    Frame = new CGRect(10, 20 + totalSize, 50, 50)
                };
                pstImage.Layer.CornerRadius = 25;
                scrollView.Add(pstImage);

                scrollView.Add(new UILabel
                {
                    Frame = new CGRect(65, 25 + totalSize, UIScreen.MainScreen.Bounds.Width, 20),
                    Text = post.Miembro_Nombre + " " + post.Miembro_Apellidos,
                    Font = UIFont.BoldSystemFontOfSize(16)
                });
                UILabel lblfecha = new STLLabel(post.POST_FECHA, 45 + totalSize, 12);
                lblfecha.Frame = new CGRect(65, 35 + totalSize, UIScreen.MainScreen.Bounds.Width, 50);
                scrollView.Add(lblfecha);

                //Likes
                UIButton btnLike = new STLButton(new WorklabsMx.Controllers.EscritorioController().GetLikes(post.POST_ID) + " Like(s)")
                {
                    Frame = new CGRect(10, 75 + totalSize, UIScreen.MainScreen.Bounds.Width - 100, 20),
                    Font = UIFont.SystemFontOfSize(10),
                    BackgroundColor = UIColor.White,

                };
                btnLike.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
                btnLike.SetImage(UIImage.FromBundle("ic_thumb_up"), UIControlState.Normal);
                btnLike.TouchUpInside += (sender, e) =>
                {
                    btnLike.BackgroundColor = UIColor.White;
                    MessageDialog msg = new MessageDialog();
                    msg.SendMessage(post.POST_ID, "");
                };
                btnLike.TouchDown += (sender, e) =>
                {
                    btnLike.BackgroundColor = UIColor.LightGray;

                };
                scrollView.Add(btnLike);

                if (post.POST_FOTO_URL != "")
                {
                    UIImageView imgPost = new STLImageView(110 + totalSize, post.POST_FOTO_URL);
                    imgPost.Frame = new CGRect(10, 140 + totalSize, UIScreen.MainScreen.Bounds.Width - 100, 100);
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

                UITextField txtComentario = new STLTextField("Escribe un comentario", 215 + totalSize);
                txtComentario.Frame = new CGRect(5, 140 + totalSize, UIScreen.MainScreen.Bounds.Width - 50, 30);
                scrollView.Add(txtComentario);

                UIButton btnComentar = new STLButton("")
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 140 + totalSize, 30, 30),
                    BackgroundColor = UIColor.LightGray
                };
                btnComentar.Layer.CornerRadius = 15;
                btnComentar.SetImage(UIImage.FromBundle("ic_send"), UIControlState.Normal);
                btnComentar.TouchUpInside += (sender, e) =>
                {
                    //btnPublicar.BackgroundColor = UIColor.FromRGB(101, 216, 250);
                };
                scrollView.Add(btnComentar);


                #region Comentarios
                AddCommentsPost(post.POST_ID);
                #endregion
                totalSize += 180;
            }
        }

        private void AddCommentsPost(string post_id)
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

        void BtnPublicar_TouchUpInside(object sender, EventArgs e)
        {
			viewView.Frame = new CGRect(5, 50, UIScreen.MainScreen.Bounds.Width, 30);
            scrollView.Frame = new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height);
            imagen.Hidden = true;
			//btnPublicar.BackgroundColor = UIColor.FromRGB(101, 216, 250);
		}
    }


}