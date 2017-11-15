// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace WorklabsMx.iOS
{
    [Register ("EscritorioHeaderCell")]
    partial class EscritorioHeaderCell
    {
        [Outlet]
        UIKit.UIImageView impPublicar { get; set; }


        [Outlet]
        UIKit.UILabel lblNombre { get; set; }


        [Outlet]
        UIKit.UILabel lblProfesion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPublicar { get; set; }

        [Action ("btnPublicar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnPublicar_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnPublicar != null) {
                btnPublicar.Dispose ();
                btnPublicar = null;
            }

            if (impPublicar != null) {
                impPublicar.Dispose ();
                impPublicar = null;
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