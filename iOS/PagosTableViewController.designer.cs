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
    [Register ("PagosTableViewController")]
    partial class PagosTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnPagar { get; set; }

        [Action ("btnPagar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnPagar_Touch (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnPagar != null) {
                btnPagar.Dispose ();
                btnPagar = null;
            }
        }
    }
}