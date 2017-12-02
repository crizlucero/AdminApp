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
    [Register ("SalaJuntasTableViewController")]
    partial class SalaJuntasTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAgendarSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnComprarHoras { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEditar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEditarSalaJuntas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHorasDisponibles { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSucursal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwCalendarioJuntas { get; set; }

        [Action ("AgendarSala_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AgendarSala_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnEditar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnEditar_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnSalaJuntas_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSalaJuntas_TouchUpInside (UIKit.UIButton sender);

        [Action ("comprarHoras_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void comprarHoras_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAgendarSala != null) {
                btnAgendarSala.Dispose ();
                btnAgendarSala = null;
            }

            if (btnComprarHoras != null) {
                btnComprarHoras.Dispose ();
                btnComprarHoras = null;
            }

            if (btnEditar != null) {
                btnEditar.Dispose ();
                btnEditar = null;
            }

            if (btnEditarSalaJuntas != null) {
                btnEditarSalaJuntas.Dispose ();
                btnEditarSalaJuntas = null;
            }

            if (lblHorasDisponibles != null) {
                lblHorasDisponibles.Dispose ();
                lblHorasDisponibles = null;
            }

            if (lblSucursal != null) {
                lblSucursal.Dispose ();
                lblSucursal = null;
            }

            if (vwCalendarioJuntas != null) {
                vwCalendarioJuntas.Dispose ();
                vwCalendarioJuntas = null;
            }
        }
    }
}