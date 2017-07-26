using Foundation;
using System;
using UIKit;
using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;

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
                Frame = new CoreGraphics.CGRect(UIScreen.MainScreen.Bounds.Width / 5,
                                                UIScreen.MainScreen.Bounds.Height / 4,
                                                 (UIScreen.MainScreen.Bounds.Width*3 / 5),
                                                 (UIScreen.MainScreen.Bounds.Width*3 / 5))

            };
            View.Add(imgQr);
        }
    }
}