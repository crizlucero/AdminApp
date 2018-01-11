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
    [Register ("ConfirmarSalaJuntasController")]
    partial class ConfirmarSalaJuntasController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnConfirmar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwVsitaConfirmar { get; set; }

        [Action ("btnCancelar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCancelar_Touch (UIKit.UIButton sender);

        [Action ("btnConfirmar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnConfirmar_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnConfirmar != null) {
                btnConfirmar.Dispose ();
                btnConfirmar = null;
            }

            if (vwVsitaConfirmar != null) {
                vwVsitaConfirmar.Dispose ();
                vwVsitaConfirmar = null;
            }
        }
    }
}