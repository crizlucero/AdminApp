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
    [Register ("InfoConfirmacionViewController")]
    partial class InfoConfirmacionViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAdelante { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAtras { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnContinuar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDiaNumero { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHoraInicioFin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNivel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView svwInfoConfirmacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwDiaNumero { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwInfoConfirmacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwVistaInfoReservacion { get; set; }

        [Action ("btnAdelante_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAdelante_Touch (UIKit.UIButton sender);

        [Action ("btnAtras_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAtras_Touch (UIKit.UIButton sender);

        [Action ("btnContinuar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnContinuar_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAdelante != null) {
                btnAdelante.Dispose ();
                btnAdelante = null;
            }

            if (btnAtras != null) {
                btnAtras.Dispose ();
                btnAtras = null;
            }

            if (btnContinuar != null) {
                btnContinuar.Dispose ();
                btnContinuar = null;
            }

            if (lblDia != null) {
                lblDia.Dispose ();
                lblDia = null;
            }

            if (lblDiaNumero != null) {
                lblDiaNumero.Dispose ();
                lblDiaNumero = null;
            }

            if (lblHoraInicioFin != null) {
                lblHoraInicioFin.Dispose ();
                lblHoraInicioFin = null;
            }

            if (lblNivel != null) {
                lblNivel.Dispose ();
                lblNivel = null;
            }

            if (lblNombreSala != null) {
                lblNombreSala.Dispose ();
                lblNombreSala = null;
            }

            if (svwInfoConfirmacion != null) {
                svwInfoConfirmacion.Dispose ();
                svwInfoConfirmacion = null;
            }

            if (vwDiaNumero != null) {
                vwDiaNumero.Dispose ();
                vwDiaNumero = null;
            }

            if (vwInfoConfirmacion != null) {
                vwInfoConfirmacion.Dispose ();
                vwInfoConfirmacion = null;
            }

            if (vwVistaInfoReservacion != null) {
                vwVistaInfoReservacion.Dispose ();
                vwVistaInfoReservacion = null;
            }
        }
    }
}