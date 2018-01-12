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
    [Register ("ReservacionTableViewCell")]
    partial class ReservacionTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCantidadHoras { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCreditos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDiaMes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHoraInicioFin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNivel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSalaNombre { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgSala != null) {
                imgSala.Dispose ();
                imgSala = null;
            }

            if (lblCantidadHoras != null) {
                lblCantidadHoras.Dispose ();
                lblCantidadHoras = null;
            }

            if (lblCreditos != null) {
                lblCreditos.Dispose ();
                lblCreditos = null;
            }

            if (lblDiaMes != null) {
                lblDiaMes.Dispose ();
                lblDiaMes = null;
            }

            if (lblHoraInicioFin != null) {
                lblHoraInicioFin.Dispose ();
                lblHoraInicioFin = null;
            }

            if (lblNivel != null) {
                lblNivel.Dispose ();
                lblNivel = null;
            }

            if (lblSalaNombre != null) {
                lblSalaNombre.Dispose ();
                lblSalaNombre = null;
            }
        }
    }
}