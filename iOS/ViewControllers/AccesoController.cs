using System;
using UIKit;
//using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using CoreGraphics;
using System.Threading.Tasks;
//using PerpetualEngine.Storage;
using System.Collections.Generic;
using Foundation;
using System.Text.RegularExpressions;
using BigTed;
using System.Timers;

namespace WorklabsMx.iOS
{
    public partial class AccesoController : UIViewController
    {
        string strAcceso = string.Empty;
        public AccesoController(IntPtr handle) : base(handle) { }
        private Timer timer1; 
        public override void ViewDidLoad()
        {
            
            base.ViewDidLoad();
  
            this.RefreshAccess();
            this.InitTimer();
            strAcceso = new MiembrosController().GetLlaveAcceso(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));

            UIButton btnRefresh = new STLButton("")
            {
                Frame = new CGRect((UIScreen.MainScreen.Bounds.Width / 2) - 25, (UIScreen.MainScreen.Bounds.Height * 3 / 5), 50, 50)
            };

            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_refresh"), UIBarButtonItemStyle.Plain, async (sender, e) =>
            {
                BTProgressHUD.Show(status: "Actualizando QR");
                await Task.Delay(2000);
                this.RefreshAccess();
            }), true);
        }

        private void RefreshAccess()
        {
            if(InternetConectionHelper.VerificarConexion())
            {
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
                {
                    Console.WriteLine(newAcceso);
                }
            }
            BTProgressHUD.Dismiss();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Elapsed += new ElapsedEventHandler(timer1_Tick);
            timer1.Interval = 300000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshAccess();
        }

      
    }
}