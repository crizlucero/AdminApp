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
    [Register ("HoraInicioView")]
    partial class HoraInicioView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCancelar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSeleccionar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker dtpHoraInicio { get; set; }

        [Action ("btnCancelar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCancelar_Touch (UIKit.UIButton sender);

        [Action ("btnSeleccionar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSeleccionar_Touch (UIKit.UIButton sender);

        [Action ("dtpHoraInicio_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void dtpHoraInicio_Changed (UIKit.UIDatePicker sender);

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

            if (dtpHoraInicio != null) {
                dtpHoraInicio.Dispose ();
                dtpHoraInicio = null;
            }
        }
    }
}