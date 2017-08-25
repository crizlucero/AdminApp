// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WorklabsMx.iOS
{
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnIniciarSesion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRecuperar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRegistro { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRestaurar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NotNowButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmailRecuperar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPassword { get; set; }

        [Action ("BtnIniciarSesion_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnIniciarSesion_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnRegistro_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnRegistro_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnRestaurar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnRestaurar_TouchUpInside (UIKit.UIButton sender);

        [Action ("LoginButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LoginButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("NotNowButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NotNowButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnIniciarSesion != null) {
                btnIniciarSesion.Dispose ();
                btnIniciarSesion = null;
            }

            if (btnRecuperar != null) {
                btnRecuperar.Dispose ();
                btnRecuperar = null;
            }

            if (btnRegistro != null) {
                btnRegistro.Dispose ();
                btnRegistro = null;
            }

            if (btnRestaurar != null) {
                btnRestaurar.Dispose ();
                btnRestaurar = null;
            }

            if (LoginButton != null) {
                LoginButton.Dispose ();
                LoginButton = null;
            }

            if (NotNowButton != null) {
                NotNowButton.Dispose ();
                NotNowButton = null;
            }

            if (txtEmail != null) {
                txtEmail.Dispose ();
                txtEmail = null;
            }

            if (txtEmailRecuperar != null) {
                txtEmailRecuperar.Dispose ();
                txtEmailRecuperar = null;
            }

            if (txtPassword != null) {
                txtPassword.Dispose ();
                txtPassword = null;
            }
        }
    }
}