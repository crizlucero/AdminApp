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
    [Register ("ComentariosBodyCell")]
    partial class ComentariosBodyCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnImagenComentatio { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnImgPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLikes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaPost { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLikes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblOcupacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtComentario { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwVistaComentario { get; set; }

        [Action ("btnComentarPost_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnComentarPost_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnImagenComentatio_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnImagenComentatio_Touch (UIKit.UIButton sender);

        [Action ("btnImgPerfil_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnImgPerfil_Touch (UIKit.UIButton sender);

        [Action ("btnLikes_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnLikes_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnImagenComentatio != null) {
                btnImagenComentatio.Dispose ();
                btnImagenComentatio = null;
            }

            if (btnImgPerfil != null) {
                btnImgPerfil.Dispose ();
                btnImgPerfil = null;
            }

            if (btnLikes != null) {
                btnLikes.Dispose ();
                btnLikes = null;
            }

            if (imgComentarios != null) {
                imgComentarios.Dispose ();
                imgComentarios = null;
            }

            if (lblComentarios != null) {
                lblComentarios.Dispose ();
                lblComentarios = null;
            }

            if (lblFechaPost != null) {
                lblFechaPost.Dispose ();
                lblFechaPost = null;
            }

            if (lblLikes != null) {
                lblLikes.Dispose ();
                lblLikes = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }

            if (lblOcupacion != null) {
                lblOcupacion.Dispose ();
                lblOcupacion = null;
            }

            if (txtComentario != null) {
                txtComentario.Dispose ();
                txtComentario = null;
            }

            if (vwVistaComentario != null) {
                vwVistaComentario.Dispose ();
                vwVistaComentario = null;
            }
        }
    }
}