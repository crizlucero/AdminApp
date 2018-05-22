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
    [Register ("DetalleReservacionViewController")]
    partial class DetalleReservacionViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAvanzar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRetroceder { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSalaJuntas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCantidadPersonas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCreditosDisponibles { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCreditosUsar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDescripcion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHora { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNivel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Action ("btnAvanzar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAvanzar_Touch (UIKit.UIButton sender);

        [Action ("btnRetroceder_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnRetroceder_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAvanzar != null) {
                btnAvanzar.Dispose ();
                btnAvanzar = null;
            }

            if (btnRetroceder != null) {
                btnRetroceder.Dispose ();
                btnRetroceder = null;
            }

            if (imgSalaJuntas != null) {
                imgSalaJuntas.Dispose ();
                imgSalaJuntas = null;
            }

            if (lblCantidadPersonas != null) {
                lblCantidadPersonas.Dispose ();
                lblCantidadPersonas = null;
            }

            if (lblCreditosDisponibles != null) {
                lblCreditosDisponibles.Dispose ();
                lblCreditosDisponibles = null;
            }

            if (lblCreditosUsar != null) {
                lblCreditosUsar.Dispose ();
                lblCreditosUsar = null;
            }

            if (lblDescripcion != null) {
                lblDescripcion.Dispose ();
                lblDescripcion = null;
            }

            if (lblFecha != null) {
                lblFecha.Dispose ();
                lblFecha = null;
            }

            if (lblHora != null) {
                lblHora.Dispose ();
                lblHora = null;
            }

            if (lblNivel != null) {
                lblNivel.Dispose ();
                lblNivel = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }
        }
    }
}