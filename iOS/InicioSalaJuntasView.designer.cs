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
    [Register ("InicioSalaJuntasView")]
    partial class InicioSalaJuntasView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnMenu { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgHorario { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSala { get; set; }

        [Action ("btnMenu_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnMenu_Touch (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnMenu != null) {
                btnMenu.Dispose ();
                btnMenu = null;
            }

            if (imgHorario != null) {
                imgHorario.Dispose ();
                imgHorario = null;
            }

            if (imgSala != null) {
                imgSala.Dispose ();
                imgSala = null;
            }
        }
    }
}