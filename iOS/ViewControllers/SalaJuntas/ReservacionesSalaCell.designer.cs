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
    [Register ("ReservacionesSalaCell")]
    partial class ReservacionesSalaCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFlecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCapacidad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDiaReservacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaReservacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Action ("btnFlecha_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnFlecha_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnFlecha != null) {
                btnFlecha.Dispose ();
                btnFlecha = null;
            }

            if (lblCapacidad != null) {
                lblCapacidad.Dispose ();
                lblCapacidad = null;
            }

            if (lblDiaReservacion != null) {
                lblDiaReservacion.Dispose ();
                lblDiaReservacion = null;
            }

            if (lblFechaReservacion != null) {
                lblFechaReservacion.Dispose ();
                lblFechaReservacion = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }
        }
    }
}