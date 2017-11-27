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
    [Register ("DetailCommentImage")]
    partial class DetailCommentImage
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgCommnet { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwImageComment { get; set; }

        [Action ("btnBack_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBack_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnBack != null) {
                btnBack.Dispose ();
                btnBack = null;
            }

            if (imgCommnet != null) {
                imgCommnet.Dispose ();
                imgCommnet = null;
            }

            if (vwImageComment != null) {
                vwImageComment.Dispose ();
                vwImageComment = null;
            }
        }
    }
}