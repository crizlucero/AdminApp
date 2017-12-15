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
    [Register ("ReservarSalaJuntasViewController")]
    partial class ReservarSalaJuntasViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAgendar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAnteriorSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSeleccionFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSiguienteSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSalaJuntas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCapacidadSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCreditosDisponibles { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCreditosUsar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDiaNumero { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHorasReservadas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPisoSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView scvHorarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwBotonFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwInfoReservacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwVista { get; set; }

        [Action ("btnAgendar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAgendar_Touch (UIKit.UIButton sender);

        [Action ("btnSalanAnterior_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSalanAnterior_Touch (UIKit.UIButton sender);

        [Action ("btnSeleccionFecha_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSeleccionFecha_Touch (UIKit.UIButton sender);

        [Action ("btnSiguiente_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSiguiente_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAgendar != null) {
                btnAgendar.Dispose ();
                btnAgendar = null;
            }

            if (btnAnteriorSala != null) {
                btnAnteriorSala.Dispose ();
                btnAnteriorSala = null;
            }

            if (btnSeleccionFecha != null) {
                btnSeleccionFecha.Dispose ();
                btnSeleccionFecha = null;
            }

            if (btnSiguienteSala != null) {
                btnSiguienteSala.Dispose ();
                btnSiguienteSala = null;
            }

            if (imgSalaJuntas != null) {
                imgSalaJuntas.Dispose ();
                imgSalaJuntas = null;
            }

            if (lblCapacidadSala != null) {
                lblCapacidadSala.Dispose ();
                lblCapacidadSala = null;
            }

            if (lblCreditosDisponibles != null) {
                lblCreditosDisponibles.Dispose ();
                lblCreditosDisponibles = null;
            }

            if (lblCreditosUsar != null) {
                lblCreditosUsar.Dispose ();
                lblCreditosUsar = null;
            }

            if (lblDia != null) {
                lblDia.Dispose ();
                lblDia = null;
            }

            if (lblDiaNumero != null) {
                lblDiaNumero.Dispose ();
                lblDiaNumero = null;
            }

            if (lblHorasReservadas != null) {
                lblHorasReservadas.Dispose ();
                lblHorasReservadas = null;
            }

            if (lblNombreSala != null) {
                lblNombreSala.Dispose ();
                lblNombreSala = null;
            }

            if (lblPisoSala != null) {
                lblPisoSala.Dispose ();
                lblPisoSala = null;
            }

            if (scvHorarios != null) {
                scvHorarios.Dispose ();
                scvHorarios = null;
            }

            if (vwBotonFecha != null) {
                vwBotonFecha.Dispose ();
                vwBotonFecha = null;
            }

            if (vwInfoReservacion != null) {
                vwInfoReservacion.Dispose ();
                vwInfoReservacion = null;
            }

            if (vwVista != null) {
                vwVista.Dispose ();
                vwVista = null;
            }
        }
    }
}