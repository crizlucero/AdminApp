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
    [Register ("TableViewCellMembresias")]
    partial class TableViewCellMembresias
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker dtpFechaInicio { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCantidadMembresias { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCantidadMeses { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreMembresia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblProporcionalMes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTarifaInscripcion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTarifaMensual { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView pcwSucursal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper stpCantidadMembresias { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper stpCantidadMeses { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwMembresias { get; set; }

        [Action ("dtpFechaInicio_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void dtpFechaInicio_ValueChanged (UIKit.UIDatePicker sender);

        [Action ("stpCantidadMembresias_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void stpCantidadMembresias_ValueChanged (UIKit.UIStepper sender);

        [Action ("stpCantidadMeses_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void stpCantidadMeses_ValueChanged (UIKit.UIStepper sender);

        void ReleaseDesignerOutlets ()
        {
            if (dtpFechaInicio != null) {
                dtpFechaInicio.Dispose ();
                dtpFechaInicio = null;
            }

            if (lblCantidadMembresias != null) {
                lblCantidadMembresias.Dispose ();
                lblCantidadMembresias = null;
            }

            if (lblCantidadMeses != null) {
                lblCantidadMeses.Dispose ();
                lblCantidadMeses = null;
            }

            if (lblNombreMembresia != null) {
                lblNombreMembresia.Dispose ();
                lblNombreMembresia = null;
            }

            if (lblProporcionalMes != null) {
                lblProporcionalMes.Dispose ();
                lblProporcionalMes = null;
            }

            if (lblTarifaInscripcion != null) {
                lblTarifaInscripcion.Dispose ();
                lblTarifaInscripcion = null;
            }

            if (lblTarifaMensual != null) {
                lblTarifaMensual.Dispose ();
                lblTarifaMensual = null;
            }

            if (lblTotal != null) {
                lblTotal.Dispose ();
                lblTotal = null;
            }

            if (pcwSucursal != null) {
                pcwSucursal.Dispose ();
                pcwSucursal = null;
            }

            if (stpCantidadMembresias != null) {
                stpCantidadMembresias.Dispose ();
                stpCantidadMembresias = null;
            }

            if (stpCantidadMeses != null) {
                stpCantidadMeses.Dispose ();
                stpCantidadMeses = null;
            }

            if (vwMembresias != null) {
                vwMembresias.Dispose ();
                vwMembresias = null;
            }
        }
    }
}