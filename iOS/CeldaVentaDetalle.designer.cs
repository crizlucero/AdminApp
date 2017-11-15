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
    [Register ("CeldaVentaDetalle")]
    partial class CeldaVentaDetalle
    {
        [Outlet]
        UIKit.UILabel lblCantidad { get; set; }


        [Outlet]
        UIKit.UILabel lblNombreProducto { get; set; }


        [Outlet]
        UIKit.UILabel lblTotalPagar { get; set; }


        [Outlet]
        UIKit.UIView vwVistaDetalleVenta { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblCantidad != null) {
                lblCantidad.Dispose ();
                lblCantidad = null;
            }

            if (lblNombreProducto != null) {
                lblNombreProducto.Dispose ();
                lblNombreProducto = null;
            }

            if (lblTotalPagar != null) {
                lblTotalPagar.Dispose ();
                lblTotalPagar = null;
            }

            if (vwVistaDetalleVenta != null) {
                vwVistaDetalleVenta.Dispose ();
                vwVistaDetalleVenta = null;
            }
        }
    }
}