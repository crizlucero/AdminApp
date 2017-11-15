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
    [Register ("CanjearCuponViewController")]
    partial class CanjearCuponViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCanjearCupon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCupon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwCanjearCupon { get; set; }

        [Action ("btnBack_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBack_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnCanjear_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCanjear_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCanjearCupon != null) {
                btnCanjearCupon.Dispose ();
                btnCanjearCupon = null;
            }

            if (txtCupon != null) {
                txtCupon.Dispose ();
                txtCupon = null;
            }

            if (vwCanjearCupon != null) {
                vwCanjearCupon.Dispose ();
                vwCanjearCupon = null;
            }
        }
    }
}