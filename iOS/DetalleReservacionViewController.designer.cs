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
    [Register ("DetalleReservacionViewController")]
    partial class DetalleReservacionViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAvanzar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRetroceder { get; set; }

        [Action ("btnAvanzar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAvanzar_Touch (UIKit.UIButton sender);

        [Action ("btnRetroceder_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnRetroceder_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAvanzar != null) {
                btnAvanzar.Dispose ();
                btnAvanzar = null;
            }

            if (btnRetroceder != null) {
                btnRetroceder.Dispose ();
                btnRetroceder = null;
            }
        }
    }
}