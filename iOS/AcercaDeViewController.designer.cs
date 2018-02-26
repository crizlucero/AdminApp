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
    [Register ("AcercaDeViewController")]
    partial class AcercaDeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgEmpresa { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblAutor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCopyrigth { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblVersion { get; set; }

        [Action ("btnAtras:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAtras (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (imgEmpresa != null) {
                imgEmpresa.Dispose ();
                imgEmpresa = null;
            }

            if (lblAutor != null) {
                lblAutor.Dispose ();
                lblAutor = null;
            }

            if (lblCopyrigth != null) {
                lblCopyrigth.Dispose ();
                lblCopyrigth = null;
            }

            if (lblVersion != null) {
                lblVersion.Dispose ();
                lblVersion = null;
            }
        }
    }
}