using System;
using UIKit;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;

namespace WorklabsMx.iOS
{
    public partial class LoginViewController : UIViewController
    {
        public LoginViewModel ViewModel;

        public LoginViewController(IntPtr handle) : base(handle)
        {
            ViewModel = new LoginViewModel();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.Title = ViewModel.Title;
            var localStorage = SimpleStorage.EditGroup("Login");
            localStorage.Delete("Miembro_Id");
        }

        //partial void NotNowButton_TouchUpInside(UIButton sender) => NavigateToTabbed();

        /*partial void LoginButton_TouchUpInside(UIButton sender)
        {
            if (Settings.IsLoggedIn)
                NavigateToTabbed();
        }*/

        void NavigateToTabbed()
        {
            InvokeOnMainThread(() =>
                {
                    var app = (AppDelegate)UIApplication.SharedApplication.Delegate;
                    app.Window.RootViewController = UIStoryboard.FromName("Main", null)
                                                     .InstantiateViewController("splitViewController")
                    as UISplitViewController;
                });
        }

        partial void BtnIniciarSesion_TouchUpInside(UIButton sender)
        {
            int MiembrosId = new LoginController().MemberLogin(this.txtEmail.Text, new PassSecurity().EncodePassword(this.txtPassword.Text));
            var localStorage = SimpleStorage.EditGroup("Login");
            localStorage.Put("Miembro_Id", MiembrosId.ToString());
            if (MiembrosId > 0)
                NavigateToTabbed();
            else
            {
                MessagingCenterAlert m = new MessagingCenterAlert
                {
                    Message = "Correo y/o contraseña incorrecto",
                    Title = "Error de autenticación",
                    Cancel = "Ok"
                };

            }

        }

        partial void BtnRestaurar_TouchUpInside(UIButton sender)
        {
            string miembro = new LoginController().ValidateMember(txtEmailRecuperar.Text);
            if (miembro.Length > 0)
                new Emails().SendMail(txtEmailRecuperar.Text, miembro, new PassSecurity().GeneraIdentifier());
        }
    }
}
