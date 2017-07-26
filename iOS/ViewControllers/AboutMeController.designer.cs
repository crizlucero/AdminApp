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
    [Register ("AboutMeController")]
    partial class AboutMeController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEditar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCelular { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHabilidades { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblProfesion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPuesto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTelefono { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnEditar != null) {
                btnEditar.Dispose ();
                btnEditar = null;
            }

            if (lblCelular != null) {
                lblCelular.Dispose ();
                lblCelular = null;
            }

            if (lblHabilidades != null) {
                lblHabilidades.Dispose ();
                lblHabilidades = null;
            }

            if (lblProfesion != null) {
                lblProfesion.Dispose ();
                lblProfesion = null;
            }

            if (lblPuesto != null) {
                lblPuesto.Dispose ();
                lblPuesto = null;
            }

            if (lblTelefono != null) {
                lblTelefono.Dispose ();
                lblTelefono = null;
            }
        }
    }
}