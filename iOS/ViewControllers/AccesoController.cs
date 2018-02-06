using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using System.Threading.Tasks;
using BigTed;
using System.Timers;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class AccesoController : UIViewController
    {
        string strAcceso = string.Empty;
        public AccesoController(IntPtr handle) : base(handle) { }
        private Timer timer1; 
        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            BTProgressHUD.Show(status: "Cargando QR");
            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_refresh"), UIBarButtonItemStyle.Plain, async (sender, e) =>
            {
                BTProgressHUD.Show(status: "Actualizando QR");
                await RefreshAccess();
            }), true);
            await LoadQR();
            await RefreshAccess();
            BTProgressHUD.Dismiss();
            this.InitTimer();
        }

        async Task RefreshAccess()
        {
            await Task.Delay(50);
            if (InternetConectionHelper.VerificarConexion())
            {
                string newAcceso = new UsuariosController().GetLlaveAcceso(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
                strAcceso = newAcceso;
                imgQr.Image = ImageGallery.LoadImageUrl(newAcceso);
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

        async Task LoadQR()
        {
            await Task.Delay(50);
            strAcceso = new UsuariosController().GetLlaveAcceso(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await RefreshAccess();
        }


        partial void btnMenu(UIBarButtonItem sender)
        {
            this.View.EndEditing(true);
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }
    }
}