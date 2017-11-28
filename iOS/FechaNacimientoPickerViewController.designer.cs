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
    [Register ("FechaNacimientoPickerViewController")]
    partial class FechaNacimientoPickerViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCancelar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSleccionar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker dtpFechaNacimiento { get; set; }

        [Action ("btnCancelar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCancelar_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnSeleccionar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSeleccionar_TouchUpInside (UIKit.UIButton sender);

        [Action ("dtpFechaNacimiento_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void dtpFechaNacimiento_ValueChanged (UIKit.UIDatePicker sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCancelar != null) {
                btnCancelar.Dispose ();
                btnCancelar = null;
            }

            if (btnSleccionar != null) {
                btnSleccionar.Dispose ();
                btnSleccionar = null;
            }

            if (dtpFechaNacimiento != null) {
                dtpFechaNacimiento.Dispose ();
                dtpFechaNacimiento = null;
            }
        }
    }
}