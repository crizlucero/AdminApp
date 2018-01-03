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
    [Register ("HeaderFavoritosTableViewCell")]
    partial class HeaderFavoritosTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtBuscar { get; set; }

        [Action ("txtBuscar_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void txtBuscar_Changed (UIKit.UITextField sender);

        [Action ("txtBuscar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void txtBuscar_Touch (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (txtBuscar != null) {
                txtBuscar.Dispose ();
                txtBuscar = null;
            }
        }
    }
}