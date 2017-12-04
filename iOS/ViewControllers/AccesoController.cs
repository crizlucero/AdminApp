using System;
using UIKit;
//using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using CoreGraphics;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class AccesoController : UIViewController
    {
        string strAcceso = string.Empty;
        public AccesoController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            
            base.ViewDidLoad();
            imgQr.Image = ImageGallery.LoadImageUrl(strAcceso);
            //var storageLocal = SimpleStorage.EditGroup("Login");

            strAcceso = new MiembrosController().GetLlaveAcceso(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));

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
            //var storageLocal = SimpleStorage.EditGroup("Login");
            string newAcceso = new MiembrosController().GetLlaveAcceso(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
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