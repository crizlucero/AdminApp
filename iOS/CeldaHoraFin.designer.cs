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
    [Register ("CeldaHoraFin")]
    partial class CeldaHoraFin
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnHoraFin { get; set; }

        [Action ("btnHoraFin_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnHoraFin_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnHoraFin != null) {
                btnHoraFin.Dispose ();
                btnHoraFin = null;
            }
        }
    }
}