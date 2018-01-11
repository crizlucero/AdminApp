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
    [Register ("DetalleEmpresaViewController")]
    partial class DetalleEmpresaViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSobreMi { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSocial { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnTrabajo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton imgBackEmpresa { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton imgEmpresa { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDescripcion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombreEmpresa { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwMi { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwSocial { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwTrabajo { get; set; }

        [Action ("btnSobreMi_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSobreMi_Touch (UIKit.UIButton sender);

        [Action ("btnSocial_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSocial_Touch (UIKit.UIButton sender);

        [Action ("btnTrabajo_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnTrabajo_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnSobreMi != null) {
                btnSobreMi.Dispose ();
                btnSobreMi = null;
            }

            if (btnSocial != null) {
                btnSocial.Dispose ();
                btnSocial = null;
            }

            if (btnTrabajo != null) {
                btnTrabajo.Dispose ();
                btnTrabajo = null;
            }

            if (imgBackEmpresa != null) {
                imgBackEmpresa.Dispose ();
                imgBackEmpresa = null;
            }

            if (imgEmpresa != null) {
                imgEmpresa.Dispose ();
                imgEmpresa = null;
            }

            if (lblDescripcion != null) {
                lblDescripcion.Dispose ();
                lblDescripcion = null;
            }

            if (lblNombreEmpresa != null) {
                lblNombreEmpresa.Dispose ();
                lblNombreEmpresa = null;
            }

            if (vwMi != null) {
                vwMi.Dispose ();
                vwMi = null;
            }

            if (vwSocial != null) {
                vwSocial.Dispose ();
                vwSocial = null;
            }

            if (vwTrabajo != null) {
                vwTrabajo.Dispose ();
                vwTrabajo = null;
            }
        }
    }
}