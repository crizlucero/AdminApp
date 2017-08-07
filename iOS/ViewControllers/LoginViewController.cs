using System;
using UIKit;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using System.Collections.Generic;

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
            localStorage.Delete("Usuario_Id");
            localStorage.Delete("Usuario_Tipo");
        }

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
            List<string> MiembrosId = new LoginController().MemberLogin(this.txtEmail.Text, new PassSecurity().EncodePassword(this.txtPassword.Text));
            var localStorage = SimpleStorage.EditGroup("Login");
            localStorage.Put("Usuario_Id", MiembrosId[0]);
            localStorage.Put("Usuario_Tipo", MiembrosId[1]);
            if (MiembrosId.Count > 0)
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
