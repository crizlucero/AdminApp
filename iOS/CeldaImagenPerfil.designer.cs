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
    [Register ("CeldaImagenPerfil")]
    partial class CeldaImagenPerfil
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
        UIKit.UIImageView imgBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgcomentarios { get; set; }

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
        UIKit.UIImageView PerfilEscritorio { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwVistaComentarios { get; set; }

        [Action ("btnComentarios_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnComentarios_Touch (UIKit.UIButton sender);

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

            if (imgBack != null) {
                imgBack.Dispose ();
                imgBack = null;
            }

            if (imgcomentarios != null) {
                imgcomentarios.Dispose ();
                imgcomentarios = null;
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

            if (PerfilEscritorio != null) {
                PerfilEscritorio.Dispose ();
                PerfilEscritorio = null;
            }

            if (vwVistaComentarios != null) {
                vwVistaComentarios.Dispose ();
                vwVistaComentarios = null;
            }
        }
    }
}