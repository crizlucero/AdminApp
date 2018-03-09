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
            var result = false;
            BTProgressHUD.Show(status: "Intentando Conectar");
            await Task.Delay(1000);
            if (InternetConectionHelper.VerificarConexion())
            {
                MenuHelper.GetListConfiguraciones();
                var configuracionCorreo = MenuHelper.Configuraciones.Find(parametro => parametro.Parametro_Descripcion == "REGEX Y LONGITUD DE CORREO ELECTRONICO DEL USUARIO");
                var configuracionPassword = MenuHelper.Configuraciones.Find(parametro => parametro.Parametro_Descripcion == "REGEX Y LONGITUD DE CONTRASEÑA DEL USUARIO");
                if ((configuracionCorreo == null || configuracionPassword == null))
                {
                    BTProgressHUD.Dismiss();
                    new MessageDialog().SendToast("No pudimos conectarte a nuestros servidores");
                }
                else
                {
                    MenuHelper.GetUsuarioInfo();
                    MenuHelper.UploadImagePath = MenuHelper.Configuraciones.Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PUBLICACIONES").Parametro_Varchar_1;
                    MenuHelper.ProfileImagePath = MenuHelper.Configuraciones.Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PERFILES DE USUARIOS").Parametro_Varchar_1;
                    result = KeyChainHelper.SetKey("EmailRegex", configuracionCorreo.Parametro_Varchar_1);
                    result = KeyChainHelper.SetKey("LongitudEmail", configuracionCorreo.Parametro_Varchar_2);
                    result = KeyChainHelper.SetKey("PasswordRegex", configuracionPassword.Parametro_Varchar_1);
                    result = KeyChainHelper.SetKey("LongitudPassword", configuracionPassword.Parametro_Varchar_2);

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

            }
            BTProgressHUD.Dismiss();
            new MessageDialog().SendToast("Aun no tienes conexión a internet");
        }

    }
}