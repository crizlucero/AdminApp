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
    [Register ("MiInfoView")]
    partial class MiInfoView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvwHabilidades { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvwIntereses { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCelular { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaNacimiento { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblMidescripcion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTelefono { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cvwHabilidades != null) {
                cvwHabilidades.Dispose ();
                cvwHabilidades = null;
            }

            if (cvwIntereses != null) {
                cvwIntereses.Dispose ();
                cvwIntereses = null;
            }

            if (lblCelular != null) {
                lblCelular.Dispose ();
                lblCelular = null;
            }

            if (lblEmail != null) {
                lblEmail.Dispose ();
                lblEmail = null;
            }

            if (lblFechaNacimiento != null) {
                lblFechaNacimiento.Dispose ();
                lblFechaNacimiento = null;
            }

            if (lblMidescripcion != null) {
                lblMidescripcion.Dispose ();
                lblMidescripcion = null;
            }

            if (lblTelefono != null) {
                lblTelefono.Dispose ();
                lblTelefono = null;
            }
        }
    }
}