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
    [Register ("EditarRedesSocialesTableViewController")]
    partial class EditarRedesSocialesTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPaginaWeb { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtUsuarioFacebook { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtUsuarioInstagram { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtUsuarioTwitter { get; set; }

        [Action ("btnGardar:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnGardar (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (txtPaginaWeb != null) {
                txtPaginaWeb.Dispose ();
                txtPaginaWeb = null;
            }

            if (txtUsuarioFacebook != null) {
                txtUsuarioFacebook.Dispose ();
                txtUsuarioFacebook = null;
            }

            if (txtUsuarioInstagram != null) {
                txtUsuarioInstagram.Dispose ();
                txtUsuarioInstagram = null;
            }

            if (txtUsuarioTwitter != null) {
                txtUsuarioTwitter.Dispose ();
                txtUsuarioTwitter = null;
            }
        }
    }
}