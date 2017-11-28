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
    [Register ("GeneroViewController")]
    partial class GeneroViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCancelar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSeleccionar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView dtpGenero { get; set; }

        [Action ("btnCancelar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCancelar_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnSeleccionar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSeleccionar_TouchUpInside (UIKit.UIButton sender);

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

            if (dtpGenero != null) {
                dtpGenero.Dispose ();
                dtpGenero = null;
            }
        }
    }
}