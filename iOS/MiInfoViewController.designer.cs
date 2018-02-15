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
    [Register ("MiInfoViewController")]
    partial class MiInfoViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvwHabilidades { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvwIntereses { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSobreMi { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtSobreMi { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cvwHabilidades != null) {
                cvwHabilidades.Dispose ();
                cvwHabilidades = null;
            }

            if (cvwIntereses != null) {
                cvwIntereses.Dispose ();
                cvwIntereses = null;
            }

            if (lblSobreMi != null) {
                lblSobreMi.Dispose ();
                lblSobreMi = null;
            }

            if (txtSobreMi != null) {
                txtSobreMi.Dispose ();
                txtSobreMi = null;
            }
        }
    }
}