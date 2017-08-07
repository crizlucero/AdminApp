using System;
using UIKit;
using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using CoreGraphics;
using System.Threading;

namespace WorklabsMx.iOS
{
    public partial class AccesoController : UIViewController
    {
        UIImageView imgQr;
        public AccesoController(IntPtr handle) : base(handle)
        {
            ThreadPool.QueueUserWorkItem((x) => this.RunRefreshAccess());
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var storageLocal = SimpleStorage.EditGroup("Login");
            imgQr = new UIImageView
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
               RefreshAccess();
               loadPop.Hide();
           };
            View.Add(btnRefresh);
        }

        void RefreshAccess()
        {
            var storageLocal = SimpleStorage.EditGroup("Login");
            imgQr.Image = ImageGallery.LoadImageUrl(new MiembrosController().GetLlaveAcceso(storageLocal.Get("Miembro_Id")));
        }

        void RunRefreshAccess()
        {
            EventWaitHandle handle = new EventWaitHandle(false, EventResetMode.ManualReset, "GoodMutexName");

            while (true)
            {
                handle.WaitOne(2000);
                this.RefreshAccess();
                handle.Reset();
                return;
            }
        }
    }
}