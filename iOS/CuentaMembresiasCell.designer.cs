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
    [Register ("CuentaMembresiasCell")]
    partial class CuentaMembresiasCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRenovar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCantidad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaVencimiento { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreMembresia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwMembresias { get; set; }

        [Action ("btnRenovar_TouchUPInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnRenovar_TouchUPInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnRenovar != null) {
                btnRenovar.Dispose ();
                btnRenovar = null;
            }

            if (lblCantidad != null) {
                lblCantidad.Dispose ();
                lblCantidad = null;
            }

            if (lblFechaVencimiento != null) {
                lblFechaVencimiento.Dispose ();
                lblFechaVencimiento = null;
            }

            if (lblNombreMembresia != null) {
                lblNombreMembresia.Dispose ();
                lblNombreMembresia = null;
            }

            if (vwMembresias != null) {
                vwMembresias.Dispose ();
                vwMembresias = null;
            }
        }
    }
}