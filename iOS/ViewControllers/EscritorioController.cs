using Foundation;
using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class EscritorioController : UIViewController
    {
        //UIImagePickerController imagePicker;
        //UIButton choosePhotoButton;
        //UIImageView imageView;
        //ImageGallery selectImage;
        UIScrollView scrollView;
        static int totalSize = 0;
        static int currentPage = 0;
        public EscritorioController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            #region Publicar
            var viewView = new UIView(new CGRect(0, 50, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
            UITextField txtPublish = new STLTextField("Publica algo :)", 20);
            viewView.Add(txtPublish);

            UIButton btnPublicar = new STLButton("Publicar")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 110, 20, 100, 30)
            };
            btnPublicar.TouchUpInside += (sender, e) =>
            {
                //btnPublicar.BackgroundColor = UIColor.FromRGB(101, 216, 250);
            };
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

            UIButton btnAcceso = new STLButton("Acceso")
            {
                Frame = new CGRect(0, 0, 50, 50)
            };
            UIImage imgQR = UIImage.FromBundle("ic_qr");
            btnAcceso.SetImage(imgQR, UIControlState.Normal);
            btnAcceso.Layer.CornerRadius = 25;
            btnAcceso.TouchUpInside += (sender, e) =>
            {
                UIViewController controller = this.Storyboard.InstantiateViewController("AccesoController");
                controller.Title = "Control de Acceso";
                this.NavigationController.PushViewController(controller, true);
            };


            accesoView.Add(btnAcceso);
            #endregion
            View.Add(accesoView);
        }
        /// <summary>
        /// Agrega a la pantalla los posts
        /// </summary>
        private void AddPosts()
        {
            foreach (PostModel post in new WorklabsMx.Controllers.EscritorioController().GetMuroPosts())
            {
                UIImageView pstImage = new UIImageView
                {
                    Image = ImageGallery.LoadImage(post.Miembro_Fotografia),
                    Frame = new CGRect(10, 20 + totalSize, 50, 50)
                };
                pstImage.Layer.CornerRadius = 50;
                scrollView.Add(pstImage);

                scrollView.Add(new UILabel
                {
                    Frame = new CGRect(65, 25 + totalSize, UIScreen.MainScreen.Bounds.Width, 20),
                    Text = post.Miembro_Nombre + " " + post.Miembro_Apellidos,
                    Font = UIFont.BoldSystemFontOfSize(16)
                });

                scrollView.Add(new UILabel
                {
                    Frame = new CGRect(65, 45 + totalSize, UIScreen.MainScreen.Bounds.Width, 20),
                    Text = post.POST_FECHA,
                    Font = UIFont.SystemFontOfSize(12)
                });
                if (post.POST_FOTO_URL != "")
                {
                    scrollView.Add(new UIImageView
                    {
                        Image = ImageGallery.LoadImage(post.POST_FOTO_URL),
                        Frame = new CGRect(10, 60 + totalSize, 200, 200)
                    });
                    totalSize += 160;
                }
                UILabel txtPost = new UILabel
                {
                    Frame = new CGRect(10, 60 + totalSize, UIScreen.MainScreen.Bounds.Width - 10, 100),
                    Text = post.POST_CONTENIDO,
                    Font = UIFont.SystemFontOfSize(16)
                };

                scrollView.Add(txtPost);

                #region Comentarios

                #endregion
                totalSize += 250;
            }
        }
    }


}