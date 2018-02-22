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
    [Register ("CeldaColaboradores")]
    partial class CeldaColaboradores
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgColaboradores { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblApellidos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgColaboradores != null) {
                imgColaboradores.Dispose ();
                imgColaboradores = null;
            }

            if (lblApellidos != null) {
                lblApellidos.Dispose ();
                lblApellidos = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }
        }
    }
}