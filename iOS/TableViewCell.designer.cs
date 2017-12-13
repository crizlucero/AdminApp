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
    [Register ("TableViewCell")]
    partial class TableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgViewMenu { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblMenu { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgViewMenu != null) {
                imgViewMenu.Dispose ();
                imgViewMenu = null;
            }

            if (lblMenu != null) {
                lblMenu.Dispose ();
                lblMenu = null;
            }
        }
    }
}