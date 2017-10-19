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
    [Register ("ComentarPostHeaderCell")]
    partial class ComentarPostHeaderCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnBorrarFoto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFotografia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPublicar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSleccionarFoto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtComentarPost { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwComentarPost { get; set; }

        [Action ("btnBorrarFot_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBorrarFot_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnComentar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnComentar_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnFoto_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnFoto_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnSleccionarfoto_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSleccionarfoto_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnBorrarFoto != null) {
                btnBorrarFoto.Dispose ();
                btnBorrarFoto = null;
            }

            if (btnFotografia != null) {
                btnFotografia.Dispose ();
                btnFotografia = null;
            }

            if (btnPublicar != null) {
                btnPublicar.Dispose ();
                btnPublicar = null;
            }

            if (btnSleccionarFoto != null) {
                btnSleccionarFoto.Dispose ();
                btnSleccionarFoto = null;
            }

            if (txtComentarPost != null) {
                txtComentarPost.Dispose ();
                txtComentarPost = null;
            }

            if (vwComentarPost != null) {
                vwComentarPost.Dispose ();
                vwComentarPost = null;
            }
        }
    }
}