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
    [Register ("CeldaEmpresasCell")]
    partial class CeldaEmpresasCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFotoEmpre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblEmpresas { get; set; }

        [Action ("btnImagenEmpresa_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnImagenEmpresa_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnFotoEmpre != null) {
                btnFotoEmpre.Dispose ();
                btnFotoEmpre = null;
            }

            if (lblEmpresas != null) {
                lblEmpresas.Dispose ();
                lblEmpresas = null;
            }
        }
    }
}