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
    [Register ("HeaderComentarTableView")]
    partial class HeaderComentarTableView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnComentar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnImagenComentario { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLikes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaComentario { get; set; }

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

        [Action ("btnComentar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnComentar_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnComentarios_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnComentarios_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnImagenComentarios_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnImagenComentarios_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnLikes_TouchUpInSide:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnLikes_TouchUpInSide (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnComentar != null) {
                btnComentar.Dispose ();
                btnComentar = null;
            }

            if (btnComentarios != null) {
                btnComentarios.Dispose ();
                btnComentarios = null;
            }

            if (btnImagenComentario != null) {
                btnImagenComentario.Dispose ();
                btnImagenComentario = null;
            }

            if (btnLikes != null) {
                btnLikes.Dispose ();
                btnLikes = null;
            }

            if (imgComentarios != null) {
                imgComentarios.Dispose ();
                imgComentarios = null;
            }

            if (imgPerfil != null) {
                imgPerfil.Dispose ();
                imgPerfil = null;
            }

            if (lblComentarios != null) {
                lblComentarios.Dispose ();
                lblComentarios = null;
            }

            if (lblFechaComentario != null) {
                lblFechaComentario.Dispose ();
                lblFechaComentario = null;
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