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
    [Register ("ConfirmacionReservaSalaViewController")]
    partial class ConfirmacionReservaSalaViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnConfirmar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCantidadPersonas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHoras { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNivel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreSala { get; set; }

        [Action ("btnConfirmar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnConfirmar_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnConfirmar != null) {
                btnConfirmar.Dispose ();
                btnConfirmar = null;
            }

            if (lblCantidadPersonas != null) {
                lblCantidadPersonas.Dispose ();
                lblCantidadPersonas = null;
            }

            if (lblFecha != null) {
                lblFecha.Dispose ();
                lblFecha = null;
            }

            if (lblHoras != null) {
                lblHoras.Dispose ();
                lblHoras = null;
            }

            if (lblNivel != null) {
                lblNivel.Dispose ();
                lblNivel = null;
            }

            if (lblNombreSala != null) {
                lblNombreSala.Dispose ();
                lblNombreSala = null;
            }
        }
    }
}