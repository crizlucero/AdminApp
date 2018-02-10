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
    [Register ("BodyComentarTableView")]
    partial class BodyComentarTableView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnComentar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnImagen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLikes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLikes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblProfesion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtComentario { get; set; }

        [Action ("btnComentar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnComentar_Touch (UIKit.UIButton sender);

        [Action ("btnImagen_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnImagen_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnLikes_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnLikes_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnComentar != null) {
                btnComentar.Dispose ();
                btnComentar = null;
            }

            if (btnImagen != null) {
                btnImagen.Dispose ();
                btnImagen = null;
            }

            if (btnLikes != null) {
                btnLikes.Dispose ();
                btnLikes = null;
            }

            if (imgPerfil != null) {
                imgPerfil.Dispose ();
                imgPerfil = null;
            }

            if (lblFecha != null) {
                lblFecha.Dispose ();
                lblFecha = null;
            }

            if (lblLikes != null) {
                lblLikes.Dispose ();
                lblLikes = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }

            if (lblProfesion != null) {
                lblProfesion.Dispose ();
                lblProfesion = null;
            }

            if (txtComentario != null) {
                txtComentario.Dispose ();
                txtComentario = null;
            }
        }
    }
}