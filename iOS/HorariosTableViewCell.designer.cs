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
    [Register ("HorariosTableViewCell")]
    partial class HorariosTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDisponibilidad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHorario { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblDisponibilidad != null) {
                lblDisponibilidad.Dispose ();
                lblDisponibilidad = null;
            }

            if (lblHorario != null) {
                lblHorario.Dispose ();
                lblHorario = null;
            }
        }
    }
}