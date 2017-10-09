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
    [Register ("ComentariosHeaderCell")]
    partial class ComentariosHeaderCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPublicar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblProfesion { get; set; }

        [Action ("BtnPublicar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnPublicar_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnPublicar != null) {
                btnPublicar.Dispose ();
                btnPublicar = null;
            }

            if (imgPerfil != null) {
                imgPerfil.Dispose ();
                imgPerfil = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }

            if (lblProfesion != null) {
                lblProfesion.Dispose ();
                lblProfesion = null;
            }
        }
    }
}