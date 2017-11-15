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
    [Register ("DetalleVentaViewController")]
    partial class DetalleVentaViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCantidadMeses { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCantidadProducto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDisponibilidad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblImpuesto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblProducto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSubtotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSucursal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTarifaMensual { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTarifaProporcional { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblVigencia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwDetalleProducto { get; set; }

        [Action ("btnBack_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBack_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (lblCantidadMeses != null) {
                lblCantidadMeses.Dispose ();
                lblCantidadMeses = null;
            }

            if (lblCantidadProducto != null) {
                lblCantidadProducto.Dispose ();
                lblCantidadProducto = null;
            }

            if (lblDisponibilidad != null) {
                lblDisponibilidad.Dispose ();
                lblDisponibilidad = null;
            }

            if (lblImpuesto != null) {
                lblImpuesto.Dispose ();
                lblImpuesto = null;
            }

            if (lblProducto != null) {
                lblProducto.Dispose ();
                lblProducto = null;
            }

            if (lblSubtotal != null) {
                lblSubtotal.Dispose ();
                lblSubtotal = null;
            }

            if (lblSucursal != null) {
                lblSucursal.Dispose ();
                lblSucursal = null;
            }

            if (lblTarifaMensual != null) {
                lblTarifaMensual.Dispose ();
                lblTarifaMensual = null;
            }

            if (lblTarifaProporcional != null) {
                lblTarifaProporcional.Dispose ();
                lblTarifaProporcional = null;
            }

            if (lblTotal != null) {
                lblTotal.Dispose ();
                lblTotal = null;
            }

            if (lblVigencia != null) {
                lblVigencia.Dispose ();
                lblVigencia = null;
            }

            if (vwDetalleProducto != null) {
                vwDetalleProducto.Dispose ();
                vwDetalleProducto = null;
            }
        }
    }
}