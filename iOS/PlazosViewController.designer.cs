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
    [Register ("PlazosViewController")]
    partial class PlazosViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCancelar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSeleccionar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView pcvPlazos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwPlazos { get; set; }

        [Action ("btnCancelar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCancelar_Touch (UIKit.UIButton sender);

        [Action ("btnSleccionar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSleccionar_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCancelar != null) {
                btnCancelar.Dispose ();
                btnCancelar = null;
            }

            if (btnSeleccionar != null) {
                btnSeleccionar.Dispose ();
                btnSeleccionar = null;
            }

            if (pcvPlazos != null) {
                pcvPlazos.Dispose ();
                pcvPlazos = null;
            }

            if (vwPlazos != null) {
                vwPlazos.Dispose ();
                vwPlazos = null;
            }
        }
    }
}