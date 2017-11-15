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
        UIKit.UIBarButtonItem btnCarrito { get; set; }

        [Action ("btnCarrito_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCarrito_Touch (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCarrito != null) {
                btnCarrito.Dispose ();
                btnCarrito = null;
            }
        }
    }
}