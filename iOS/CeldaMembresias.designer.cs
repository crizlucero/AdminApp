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
    [Register ("CeldaMembresias")]
    partial class CeldaMembresias
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgMembresias { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreMembresia { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgMembresias != null) {
                imgMembresias.Dispose ();
                imgMembresias = null;
            }

            if (lblNombreMembresia != null) {
                lblNombreMembresia.Dispose ();
                lblNombreMembresia = null;
            }
        }
    }
}