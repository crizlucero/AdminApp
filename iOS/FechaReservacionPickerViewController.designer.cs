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
    [Register ("FechaReservacionPickerViewController")]
    partial class FechaReservacionPickerViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCancelar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSleccionar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker dtpFechaReservacion { get; set; }

        [Action ("btnCancelar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCancelar_Touch (UIKit.UIButton sender);

        [Action ("btnSeleccionar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSeleccionar_Touch (UIKit.UIButton sender);

        [Action ("dtpFechaReservacion_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void dtpFechaReservacion_ValueChanged (UIKit.UIDatePicker sender);

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

            if (dtpFechaReservacion != null) {
                dtpFechaReservacion.Dispose ();
                dtpFechaReservacion = null;
            }
        }
    }
}