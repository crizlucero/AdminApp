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
    [Register ("CeldaLike")]
    partial class CeldaLike
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnImagenPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSeguir { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblOcupacion { get; set; }

        [Action ("btnSeguir_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSeguir_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnImagenPerfil != null) {
                btnImagenPerfil.Dispose ();
                btnImagenPerfil = null;
            }

            if (btnSeguir != null) {
                btnSeguir.Dispose ();
                btnSeguir = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }

            if (lblOcupacion != null) {
                lblOcupacion.Dispose ();
                lblOcupacion = null;
            }
        }
    }
}