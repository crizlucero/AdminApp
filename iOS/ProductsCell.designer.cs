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
    [Register ("ProductsCell")]
    partial class ProductsCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgProducto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDescripcionProducto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreProducto { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgProducto != null) {
                imgProducto.Dispose ();
                imgProducto = null;
            }

            if (lblDescripcionProducto != null) {
                lblDescripcionProducto.Dispose ();
                lblDescripcionProducto = null;
            }

            if (lblNombreProducto != null) {
                lblNombreProducto.Dispose ();
                lblNombreProducto = null;
            }
        }
    }
}