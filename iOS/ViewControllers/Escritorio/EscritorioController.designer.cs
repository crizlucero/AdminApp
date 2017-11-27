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
    [Register ("EscritorioController")]
    partial class EscritorioController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnScanQr { get; set; }

        [Action ("btnToScanQr_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnToScanQr_TouchUpInside (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnScanQr != null) {
                btnScanQr.Dispose ();
                btnScanQr = null;
            }
        }
    }
}