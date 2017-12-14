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
    [Register ("ReservacionesCell")]
    partial class ReservacionesCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFlecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCapacidadSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreSala { get; set; }

        [Action ("btnFlecha_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnFlecha_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnFlecha != null) {
                btnFlecha.Dispose ();
                btnFlecha = null;
            }

            if (lblCapacidadSala != null) {
                lblCapacidadSala.Dispose ();
                lblCapacidadSala = null;
            }

            if (lblDia != null) {
                lblDia.Dispose ();
                lblDia = null;
            }

            if (lblFecha != null) {
                lblFecha.Dispose ();
                lblFecha = null;
            }

            if (lblNombreSala != null) {
                lblNombreSala.Dispose ();
                lblNombreSala = null;
            }
        }
    }
}