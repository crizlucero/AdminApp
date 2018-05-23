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
    [Register ("SalasCollectionCell")]
    partial class SalasCollectionCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSalaCreditos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSalaNivel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSalaNombre { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgSala != null) {
                imgSala.Dispose ();
                imgSala = null;
            }

            if (lblSalaCreditos != null) {
                lblSalaCreditos.Dispose ();
                lblSalaCreditos = null;
            }

            if (lblSalaNivel != null) {
                lblSalaNivel.Dispose ();
                lblSalaNivel = null;
            }

            if (lblSalaNombre != null) {
                lblSalaNombre.Dispose ();
                lblSalaNombre = null;
            }
        }
    }
}