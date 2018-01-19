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
    [Register ("RegistroInvitadosTableViewController")]
    partial class RegistroInvitadosTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAñadir { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEnviarInvitacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnMenuIvitados { get; set; }

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
        UIKit.UITextField txtApellido { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtAsunto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNombre { get; set; }

        [Action ("btnAñadir_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAñadir_Touch (UIKit.UIButton sender);

        [Action ("btnEnviarInvitacion_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnEnviarInvitacion_Touch (UIKit.UIButton sender);

        [Action ("btnFecha_Tocuh:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnFecha_Tocuh (UIKit.UIButton sender);

        [Action ("btnMenuInvitados_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnMenuInvitados_Touch (UIKit.UIBarButtonItem sender);

        [Action ("btnUbicacion_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnUbicacion_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAñadir != null) {
                btnAñadir.Dispose ();
                btnAñadir = null;
            }

            if (btnEnviarInvitacion != null) {
                btnEnviarInvitacion.Dispose ();
                btnEnviarInvitacion = null;
            }

            if (btnMenuIvitados != null) {
                btnMenuIvitados.Dispose ();
                btnMenuIvitados = null;
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

            if (txtApellido != null) {
                txtApellido.Dispose ();
                txtApellido = null;
            }

            if (txtAsunto != null) {
                txtAsunto.Dispose ();
                txtAsunto = null;
            }

            if (txtEmail != null) {
                txtEmail.Dispose ();
                txtEmail = null;
            }

            if (txtNombre != null) {
                txtNombre.Dispose ();
                txtNombre = null;
            }
        }
    }
}