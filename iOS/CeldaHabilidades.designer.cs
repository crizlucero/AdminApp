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
    [Register ("CeldaHabilidades")]
    partial class CeldaHabilidades
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHabilidades { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblHabilidades != null) {
                lblHabilidades.Dispose ();
                lblHabilidades = null;
            }
        }
    }
}