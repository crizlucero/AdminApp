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
    [Register ("FechaHoraSalaViewController")]
    partial class FechaHoraSalaViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAvanzar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnMinutosCero { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnMinutosFin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnMinutosFinTr { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnMinutosTreinta { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRetroceder { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker dtpFecha { get; set; }

        [Action ("btnAvanzar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAvanzar_Touch (UIKit.UIButton sender);

        [Action ("btnHoraFin_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnHoraFin_Touch (UIKit.UIButton sender);

        [Action ("btnRetroceder_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnRetroceder_Touch (UIKit.UIButton sender);

        [Action ("dtpFecha_Cahnged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void dtpFecha_Cahnged (UIKit.UIDatePicker sender);

        [Action ("HoraFinCero_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void HoraFinCero_Touch (UIKit.UIButton sender);

        [Action ("HoraFinTreinta_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void HoraFinTreinta_Touch (UIKit.UIButton sender);

        [Action ("HoraInicioCero_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void HoraInicioCero_Touch (UIKit.UIButton sender);

        [Action ("HoraInicioTreinta_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void HoraInicioTreinta_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAvanzar != null) {
                btnAvanzar.Dispose ();
                btnAvanzar = null;
            }

            if (btnMinutosCero != null) {
                btnMinutosCero.Dispose ();
                btnMinutosCero = null;
            }

            if (btnMinutosFin != null) {
                btnMinutosFin.Dispose ();
                btnMinutosFin = null;
            }

            if (btnMinutosFinTr != null) {
                btnMinutosFinTr.Dispose ();
                btnMinutosFinTr = null;
            }

            if (btnMinutosTreinta != null) {
                btnMinutosTreinta.Dispose ();
                btnMinutosTreinta = null;
            }

            if (btnRetroceder != null) {
                btnRetroceder.Dispose ();
                btnRetroceder = null;
            }

            if (dtpFecha != null) {
                dtpFecha.Dispose ();
                dtpFecha = null;
            }
        }
    }
}