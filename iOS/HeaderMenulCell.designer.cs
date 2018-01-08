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
    [Register ("HeaderMenulCell")]
    partial class HeaderMenulCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnImagenPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPuesto { get; set; }

        [Action ("btnEditarPerfil_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnEditarPerfil_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnImagenPerfil != null) {
                btnImagenPerfil.Dispose ();
                btnImagenPerfil = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }

            if (lblPuesto != null) {
                lblPuesto.Dispose ();
                lblPuesto = null;
            }
        }
    }
}