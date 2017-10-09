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
        UIKit.UIImageView imgComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgLikes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDetalleComentario { get; set; }

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
        UIKit.UIView vwVistaComentario { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgComentarios != null) {
                imgComentarios.Dispose ();
                imgComentarios = null;
            }

            if (imgLikes != null) {
                imgLikes.Dispose ();
                imgLikes = null;
            }

            if (lblComentarios != null) {
                lblComentarios.Dispose ();
                lblComentarios = null;
            }

            if (lblDetalleComentario != null) {
                lblDetalleComentario.Dispose ();
                lblDetalleComentario = null;
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

            if (vwVistaComentario != null) {
                vwVistaComentario.Dispose ();
                vwVistaComentario = null;
            }
        }
    }
}