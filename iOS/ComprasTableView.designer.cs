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
    [Register ("ComprasTableView")]
    partial class ComprasTableView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvMembresias { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvProductos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl sclCompras { get; set; }

        [Action ("btnAtras_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAtras_Touch (UIKit.UIBarButtonItem sender);

        [Action ("sclCompras_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void sclCompras_Changed (UIKit.UISegmentedControl sender);

        void ReleaseDesignerOutlets ()
        {
            if (cvMembresias != null) {
                cvMembresias.Dispose ();
                cvMembresias = null;
            }

            if (cvProductos != null) {
                cvProductos.Dispose ();
                cvProductos = null;
            }

            if (sclCompras != null) {
                sclCompras.Dispose ();
                sclCompras = null;
            }
        }
    }
}