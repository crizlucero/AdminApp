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
    [Register ("PerfilTableViewController")]
    partial class PerfilTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEditarFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEditarGenero { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFotografia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaNacimiento { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblGenero { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtApellido { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtHabilidades { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtProfesion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtTelefono { get; set; }

        [Action ("btnEditarFecha_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnEditarFecha_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnEditarGenero_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnEditarGenero_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnFoto_TpuchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnFoto_TpuchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnEditarFecha != null) {
                btnEditarFecha.Dispose ();
                btnEditarFecha = null;
            }

            if (btnEditarGenero != null) {
                btnEditarGenero.Dispose ();
                btnEditarGenero = null;
            }

            if (btnFotografia != null) {
                btnFotografia.Dispose ();
                btnFotografia = null;
            }

            if (imgPerfil != null) {
                imgPerfil.Dispose ();
                imgPerfil = null;
            }

            if (lblFechaNacimiento != null) {
                lblFechaNacimiento.Dispose ();
                lblFechaNacimiento = null;
            }

            if (lblGenero != null) {
                lblGenero.Dispose ();
                lblGenero = null;
            }

            if (txtApellido != null) {
                txtApellido.Dispose ();
                txtApellido = null;
            }

            if (txtEmail != null) {
                txtEmail.Dispose ();
                txtEmail = null;
            }

            if (txtHabilidades != null) {
                txtHabilidades.Dispose ();
                txtHabilidades = null;
            }

            if (txtNombre != null) {
                txtNombre.Dispose ();
                txtNombre = null;
            }

            if (txtProfesion != null) {
                txtProfesion.Dispose ();
                txtProfesion = null;
            }

            if (txtTelefono != null) {
                txtTelefono.Dispose ();
                txtTelefono = null;
            }
        }
    }
}