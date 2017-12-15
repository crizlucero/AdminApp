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
    [Register ("CeldaSucursales")]
    partial class CeldaSucursales
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSucursal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDomicilio { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Action ("btnSucursal_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSucursal_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (imgSucursal != null) {
                imgSucursal.Dispose ();
                imgSucursal = null;
            }

            if (lblDomicilio != null) {
                lblDomicilio.Dispose ();
                lblDomicilio = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }
        }
    }
}