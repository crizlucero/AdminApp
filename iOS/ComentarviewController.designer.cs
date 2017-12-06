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
    [Register ("ComentarviewController")]
    partial class ComentarviewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCamara { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnComentar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtComentario { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwVistaComentar { get; set; }

        [Action ("btnCamara_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCamara_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnClose_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnClose_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnComentar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnComentar_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCamara != null) {
                btnCamara.Dispose ();
                btnCamara = null;
            }

            if (btnComentar != null) {
                btnComentar.Dispose ();
                btnComentar = null;
            }

            if (txtComentario != null) {
                txtComentario.Dispose ();
                txtComentario = null;
            }

            if (vwVistaComentar != null) {
                vwVistaComentar.Dispose ();
                vwVistaComentar = null;
            }
        }
    }
}