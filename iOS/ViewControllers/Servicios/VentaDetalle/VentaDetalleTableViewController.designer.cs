// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace WorklabsMx.iOS
{
    [Register ("VentaDetalleTableViewController")]
    partial class VentaDetalleTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnAtras { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnPagar { get; set; }

        [Action ("btnAtras_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAtras_Touch (UIKit.UIBarButtonItem sender);

        [Action ("btnPagar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnPagar_Touch (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAtras != null) {
                btnAtras.Dispose ();
                btnAtras = null;
            }

            if (btnPagar != null) {
                btnPagar.Dispose ();
                btnPagar = null;
            }
        }
    }
}