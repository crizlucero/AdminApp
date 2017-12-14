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
    [Register ("HeaderReservaciones")]
    partial class HeaderReservaciones
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl sgcReservacion { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (sgcReservacion != null) {
                sgcReservacion.Dispose ();
                sgcReservacion = null;
            }
        }
    }
}