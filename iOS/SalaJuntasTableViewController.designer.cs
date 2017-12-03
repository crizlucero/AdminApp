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
        UIKit.UIButton btnComprarHoras { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEditarSalaJuntas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHorasDisponibles { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSalaJuntas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwCalendarioJuntas { get; set; }

        [Action ("btnComprarHoras_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnComprarHoras_Touch (UIKit.UIButton sender);

        [Action ("btnEditarSalaJuntas_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnEditarSalaJuntas_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnComprarHoras != null) {
                btnComprarHoras.Dispose ();
                btnComprarHoras = null;
            }

            if (btnEditarSalaJuntas != null) {
                btnEditarSalaJuntas.Dispose ();
                btnEditarSalaJuntas = null;
            }

            if (lblHorasDisponibles != null) {
                lblHorasDisponibles.Dispose ();
                lblHorasDisponibles = null;
            }

            if (lblSalaJuntas != null) {
                lblSalaJuntas.Dispose ();
                lblSalaJuntas = null;
            }

            if (vwCalendarioJuntas != null) {
                vwCalendarioJuntas.Dispose ();
                vwCalendarioJuntas = null;
            }
        }
    }
}