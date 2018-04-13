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
    [Register ("NotificacionImagenFondo")]
    partial class NotificacionImagenFondo
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLikes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnOpciones { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgFondo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaPublicacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLikes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwImagenFonde { get; set; }

        [Action ("btnC:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnC (UIKit.UIButton sender);

        [Action ("btnLikes_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnLikes_Touch (UIKit.UIButton sender);

        [Action ("btnOpciones_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnOpciones_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnComentarios != null) {
                btnComentarios.Dispose ();
                btnComentarios = null;
            }

            if (btnLikes != null) {
                btnLikes.Dispose ();
                btnLikes = null;
            }

            if (btnOpciones != null) {
                btnOpciones.Dispose ();
                btnOpciones = null;
            }

            if (imgComentarios != null) {
                imgComentarios.Dispose ();
                imgComentarios = null;
            }

            if (imgFondo != null) {
                imgFondo.Dispose ();
                imgFondo = null;
            }

            if (imgPerfil != null) {
                imgPerfil.Dispose ();
                imgPerfil = null;
            }

            if (lblComentarios != null) {
                lblComentarios.Dispose ();
                lblComentarios = null;
            }

            if (lblFechaPublicacion != null) {
                lblFechaPublicacion.Dispose ();
                lblFechaPublicacion = null;
            }

            if (lblLikes != null) {
                lblLikes.Dispose ();
                lblLikes = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }

            if (vwImagenFonde != null) {
                vwImagenFonde.Dispose ();
                vwImagenFonde = null;
            }
        }
    }
}