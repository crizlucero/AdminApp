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
    [Register ("DetalleInvitacionViewController")]
    partial class DetalleInvitacionViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCerrar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgQR { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDomicilio { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreInvitado { get; set; }

        [Action ("btnCerrar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCerrar_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCerrar != null) {
                btnCerrar.Dispose ();
                btnCerrar = null;
            }

            if (imgQR != null) {
                imgQR.Dispose ();
                imgQR = null;
            }

            if (lblDomicilio != null) {
                lblDomicilio.Dispose ();
                lblDomicilio = null;
            }

            if (lblFecha != null) {
                lblFecha.Dispose ();
                lblFecha = null;
            }

            if (lblNombreInvitado != null) {
                lblNombreInvitado.Dispose ();
                lblNombreInvitado = null;
            }
        }
    }
}