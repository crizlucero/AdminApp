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
    [Register ("TabBarDetalleVenta")]
    partial class TabBarDetalleVenta
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnCarrito { get; set; }

        [Action ("btnBack_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBack_Touch (UIKit.UIBarButtonItem sender);

        [Action ("btnCarrito_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCarrito_Touch (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnBack != null) {
                btnBack.Dispose ();
                btnBack = null;
            }

            if (btnCarrito != null) {
                btnCarrito.Dispose ();
                btnCarrito = null;
            }
        }
    }
}