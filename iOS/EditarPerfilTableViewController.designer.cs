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
    [Register ("EditarPerfilTableViewController")]
    partial class EditarPerfilTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnClose { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFondoImagen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnImagen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSobreMi { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSocial { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnTrabajo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtProfesion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwImagenPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwSocial { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwTrabajo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwVistaMi { get; set; }

        [Action ("btnClose_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnClose_Touch (UIKit.UIButton sender);

        [Action ("btnImagen_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnImagen_Touch (UIKit.UIButton sender);

        [Action ("btnSobreMi_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSobreMi_Touch (UIKit.UIButton sender);

        [Action ("btnSocial_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSocial_Touch (UIKit.UIButton sender);

        [Action ("btnTrabajo_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnTrabajo_Touch (UIKit.UIButton sender);

        [Action ("FondoImagen_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FondoImagen_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnClose != null) {
                btnClose.Dispose ();
                btnClose = null;
            }

            if (btnFondoImagen != null) {
                btnFondoImagen.Dispose ();
                btnFondoImagen = null;
            }

            if (btnImagen != null) {
                btnImagen.Dispose ();
                btnImagen = null;
            }

            if (btnSobreMi != null) {
                btnSobreMi.Dispose ();
                btnSobreMi = null;
            }

            if (btnSocial != null) {
                btnSocial.Dispose ();
                btnSocial = null;
            }

            if (btnTrabajo != null) {
                btnTrabajo.Dispose ();
                btnTrabajo = null;
            }

            if (txtNombre != null) {
                txtNombre.Dispose ();
                txtNombre = null;
            }

            if (txtProfesion != null) {
                txtProfesion.Dispose ();
                txtProfesion = null;
            }

            if (vwImagenPerfil != null) {
                vwImagenPerfil.Dispose ();
                vwImagenPerfil = null;
            }

            if (vwSocial != null) {
                vwSocial.Dispose ();
                vwSocial = null;
            }

            if (vwTrabajo != null) {
                vwTrabajo.Dispose ();
                vwTrabajo = null;
            }

            if (vwVistaMi != null) {
                vwVistaMi.Dispose ();
                vwVistaMi = null;
            }
        }
    }
}