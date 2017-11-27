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
    [Register ("VentaDetalleHeader")]
    partial class VentaDetalleHeader
    {
        [Outlet]
        UIKit.UIButton btnUsarCupon { get; set; }


        [Outlet]
        UIKit.UILabel lblDescuento { get; set; }


        [Outlet]
        UIKit.UILabel lblImpuesto { get; set; }


        [Outlet]
        UIKit.UILabel lblSubtotal { get; set; }


        [Outlet]
        UIKit.UILabel lblTotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLeyendaTotalDescuento { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTotalConDescuento { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnUsarCupon != null) {
                btnUsarCupon.Dispose ();
                btnUsarCupon = null;
            }

            if (lblDescuento != null) {
                lblDescuento.Dispose ();
                lblDescuento = null;
            }

            if (lblImpuesto != null) {
                lblImpuesto.Dispose ();
                lblImpuesto = null;
            }

            if (lblLeyendaTotalDescuento != null) {
                lblLeyendaTotalDescuento.Dispose ();
                lblLeyendaTotalDescuento = null;
            }

            if (lblSubtotal != null) {
                lblSubtotal.Dispose ();
                lblSubtotal = null;
            }

            if (lblTotal != null) {
                lblTotal.Dispose ();
                lblTotal = null;
            }

            if (lblTotalConDescuento != null) {
                lblTotalConDescuento.Dispose ();
                lblTotalConDescuento = null;
            }
        }
    }
}