using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using BigTed;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class NoConexionViewController : UIViewController
    {
        public NoConexionViewController (IntPtr handle) : base (handle)
        {
        }

        partial void btnConectar_Touch(UIButton sender)
        {
            this.VerificarConn();
        }

        private async void VerificarConn()
        {
            BTProgressHUD.Show(status: "Intentando Conectar");
            await Task.Delay(1000);
            if (InternetConectionHelper.VerificarConexion())
            {
                var app = (AppDelegate)UIApplication.SharedApplication.Delegate;
                if (!string.IsNullOrEmpty(KeyChainHelper.GetKey("Usuario_Id")) && !string.IsNullOrEmpty(KeyChainHelper.GetKey("Usuario_Tipo")))
                {
                    app.Window.RootViewController = UIStoryboard.FromName("Main", null).InstantiateViewController("NavEscritorio") as UIViewController;
                }
                else
                {
                    app.Window.RootViewController = UIStoryboard.FromName("Main", null).InstantiateViewController("LoginViewController") as UIViewController;
                }
            }
            BTProgressHUD.Dismiss();
            new MessageDialog().SendToast("Aun no tienes conexión a internet");
        }

    }
}