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
    [Register ("CuentaProductosCell")]
    partial class CuentaProductosCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAgregar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCantidad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaVencimiento { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreProducto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwProductos { get; set; }

        [Action ("btnAgregar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAgregar_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAgregar != null) {
                btnAgregar.Dispose ();
                btnAgregar = null;
            }

            if (lblCantidad != null) {
                lblCantidad.Dispose ();
                lblCantidad = null;
            }

            if (lblFechaVencimiento != null) {
                lblFechaVencimiento.Dispose ();
                lblFechaVencimiento = null;
            }

            if (lblNombreProducto != null) {
                lblNombreProducto.Dispose ();
                lblNombreProducto = null;
            }

            if (vwProductos != null) {
                vwProductos.Dispose ();
                vwProductos = null;
            }
        }
    }
}