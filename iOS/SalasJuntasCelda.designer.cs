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
    [Register ("SalasJuntasCelda")]
    partial class SalasJuntasCelda
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSalaJuntas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCapacidad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreSala { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPiso { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgSalaJuntas != null) {
                imgSalaJuntas.Dispose ();
                imgSalaJuntas = null;
            }

            if (lblCapacidad != null) {
                lblCapacidad.Dispose ();
                lblCapacidad = null;
            }

            if (lblNombreSala != null) {
                lblNombreSala.Dispose ();
                lblNombreSala = null;
            }

            if (lblPiso != null) {
                lblPiso.Dispose ();
                lblPiso = null;
            }
        }
    }
}