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
    [Register ("RedesSocialesTableViewCell")]
    partial class RedesSocialesTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgImagenRedSocial { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblRedSocial { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgImagenRedSocial != null) {
                imgImagenRedSocial.Dispose ();
                imgImagenRedSocial = null;
            }

            if (lblRedSocial != null) {
                lblRedSocial.Dispose ();
                lblRedSocial = null;
            }
        }
    }
}