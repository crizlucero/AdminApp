using Foundation;
using System;
using UIKit;
using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using CoreGraphics;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class AccesoController : UIViewController
    {
        public AccesoController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var storageLocal = SimpleStorage.EditGroup("Login");
            UIImageView imgQr = new UIImageView
            {
                Image = ImageGallery.LoadImageUrl(new MiembrosController().GetLlaveAcceso(storageLocal.Get("Miembro_Id"))),
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 5,
                                                UIScreen.MainScreen.Bounds.Height / 4,
                                                 (UIScreen.MainScreen.Bounds.Width * 3 / 5),
                                                 (UIScreen.MainScreen.Bounds.Width * 3 / 5))
            };

            View.Add(imgQr);

            UIButton btnRefresh = new STLButton("")
            {
                Frame = new CGRect((UIScreen.MainScreen.Bounds.Width / 2) - 25, (UIScreen.MainScreen.Bounds.Height * 3 / 5), 50, 50)
            };
            UIImage imgRefresh = UIImage.FromBundle("ic_refresh");
            btnRefresh.SetImage(imgRefresh, UIControlState.Normal);
            btnRefresh.Layer.CornerRadius = 25;
            btnRefresh.TouchUpInside += (sender, e) =>
           {
               LoadingView loadPop = new LoadingView(UIScreen.MainScreen.Bounds);
               View.Add(loadPop);
               imgQr.Image = ImageGallery.LoadImageUrl(new MiembrosController().GetLlaveAcceso(storageLocal.Get("Miembro_Id")));
               loadPop.Hide();
           };
            View.Add(btnRefresh);
        }
    }
}