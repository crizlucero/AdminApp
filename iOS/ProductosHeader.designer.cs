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
    [Register ("ProductosHeader")]
    partial class ProductosHeader
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCantidadProductos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTotalPagar { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblCantidadProductos != null) {
                lblCantidadProductos.Dispose ();
                lblCantidadProductos = null;
            }

            if (lblTotalPagar != null) {
                lblTotalPagar.Dispose ();
                lblTotalPagar = null;
            }
        }
    }
}