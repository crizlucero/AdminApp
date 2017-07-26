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
    [Register ("PerfilController")]
    partial class PerfilController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgMiembro { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCorreo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaNacimiento { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblGenero { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgMiembro != null) {
                imgMiembro.Dispose ();
                imgMiembro = null;
            }

            if (lblCorreo != null) {
                lblCorreo.Dispose ();
                lblCorreo = null;
            }

            if (lblFechaNacimiento != null) {
                lblFechaNacimiento.Dispose ();
                lblFechaNacimiento = null;
            }

            if (lblGenero != null) {
                lblGenero.Dispose ();
                lblGenero = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }
        }
    }
}