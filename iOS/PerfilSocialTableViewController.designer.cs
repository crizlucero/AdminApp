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
    [Register ("PerfilSocialTableViewController")]
    partial class PerfilSocialTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvwTablaRedesSociales { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPublicaciones { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSeguidores { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSiguiendo { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cvwTablaRedesSociales != null) {
                cvwTablaRedesSociales.Dispose ();
                cvwTablaRedesSociales = null;
            }

            if (lblPublicaciones != null) {
                lblPublicaciones.Dispose ();
                lblPublicaciones = null;
            }

            if (lblSeguidores != null) {
                lblSeguidores.Dispose ();
                lblSeguidores = null;
            }

            if (lblSiguiendo != null) {
                lblSiguiendo.Dispose ();
                lblSiguiendo = null;
            }
        }
    }
}