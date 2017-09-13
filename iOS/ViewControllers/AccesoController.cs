using System;
using UIKit;
using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using CoreGraphics;
using System.Threading;
using System.Threading.Tasks;
using Foundation;

namespace WorklabsMx.iOS
{
    public partial class AccesoController : UIViewController
    {
        UIImageView imgQr;
        string strAcceso = string.Empty;
        public AccesoController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var storageLocal = SimpleStorage.EditGroup("Login");
            strAcceso = new MiembrosController().GetLlaveAcceso(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));

            imgQr = new UIImageView
            {
                Image = ImageGallery.LoadImageUrl(strAcceso),
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 5, UIScreen.MainScreen.Bounds.Height / 4,
                                  (UIScreen.MainScreen.Bounds.Width * 3 / 5), (UIScreen.MainScreen.Bounds.Width * 3 / 5))
            };

            View.Add(imgQr);

            UIButton btnRefresh = new STLButton("")
            {
                Frame = new CGRect((UIScreen.MainScreen.Bounds.Width / 2) - 25, (UIScreen.MainScreen.Bounds.Height * 3 / 5), 50, 50)
            };

            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_refresh"), UIBarButtonItemStyle.Plain, async (sender, e) =>
            {
                await RunRefreshAccess();
            }), true);
        }

        void RefreshAccess()
        {
            var storageLocal = SimpleStorage.EditGroup("Login");
            string newAcceso = new MiembrosController().GetLlaveAcceso(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));
            if (!strAcceso.Equals(newAcceso))
            {
                LoadingView loadPop = new LoadingView(UIScreen.MainScreen.Bounds);
                View.Add(loadPop);
                strAcceso = newAcceso;
                imgQr.Image = ImageGallery.LoadImageUrl(newAcceso);
                loadPop.Hide();
            }
            else
                Console.WriteLine(newAcceso);
        }

        async Task RunRefreshAccess()
        {

            while (true)
            {
                await Task.Delay(30000);

                RefreshAccess();
            }
        }
    }
}