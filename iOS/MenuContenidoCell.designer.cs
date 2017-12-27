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
    [Register ("MenuContenidoCell")]
    partial class MenuContenidoCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblMenuNombre { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblMenuNombre != null) {
                lblMenuNombre.Dispose ();
                lblMenuNombre = null;
            }
        }
    }
}