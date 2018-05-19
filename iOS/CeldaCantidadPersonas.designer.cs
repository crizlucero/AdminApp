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
    [Register ("CeldaCantidadPersonas")]
    partial class CeldaCantidadPersonas
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCantidadPersonas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwCantidadPersonas { get; set; }

        [Action ("btnCantidadPersonas_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCantidadPersonas_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCantidadPersonas != null) {
                btnCantidadPersonas.Dispose ();
                btnCantidadPersonas = null;
            }

            if (vwCantidadPersonas != null) {
                vwCantidadPersonas.Dispose ();
                vwCantidadPersonas = null;
            }
        }
    }
}