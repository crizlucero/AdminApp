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
    [Register ("SeleccionarSalaTableView")]
    partial class SeleccionarSalaTableView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRetroceder { get; set; }

        [Action ("btnRetroceder_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnRetroceder_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnRetroceder != null) {
                btnRetroceder.Dispose ();
                btnRetroceder = null;
            }
        }
    }
}