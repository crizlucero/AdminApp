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
    [Register ("CeldaDetalleInvitacion")]
    partial class CeldaDetalleInvitacion
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAgregar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnInvitar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnUbicacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblUbicacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtAsunto { get; set; }

        [Action ("btnAgregar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAgregar_Touch (UIKit.UIButton sender);

        [Action ("btnFecha_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnFecha_Touch (UIKit.UIButton sender);

        [Action ("btnInvitar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnInvitar_Touch (UIKit.UIButton sender);

        [Action ("btnUbicacion_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnUbicacion_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAgregar != null) {
                btnAgregar.Dispose ();
                btnAgregar = null;
            }

            if (btnFecha != null) {
                btnFecha.Dispose ();
                btnFecha = null;
            }

            if (btnInvitar != null) {
                btnInvitar.Dispose ();
                btnInvitar = null;
            }

            if (btnUbicacion != null) {
                btnUbicacion.Dispose ();
                btnUbicacion = null;
            }

            if (lblFecha != null) {
                lblFecha.Dispose ();
                lblFecha = null;
            }

            if (lblUbicacion != null) {
                lblUbicacion.Dispose ();
                lblUbicacion = null;
            }

            if (txtAsunto != null) {
                txtAsunto.Dispose ();
                txtAsunto = null;
            }
        }
    }
}