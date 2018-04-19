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
    [Register ("ComprasTableView")]
    partial class ComprasTableView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnMemb { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnProductos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvMembresias { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvProductos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgBanner { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTotal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwMembresias { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwProductos { get; set; }

        [Action ("btnAtras_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAtras_Touch (UIKit.UIBarButtonItem sender);

        [Action ("btnCarrito_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCarrito_Touch (UIKit.UIBarButtonItem sender);

        [Action ("btnMembresias:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnMembresias (UIKit.UIButton sender);

        [Action ("btnProductos_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnProductos_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnMemb != null) {
                btnMemb.Dispose ();
                btnMemb = null;
            }

            if (btnProductos != null) {
                btnProductos.Dispose ();
                btnProductos = null;
            }

            if (cvMembresias != null) {
                cvMembresias.Dispose ();
                cvMembresias = null;
            }

            if (cvProductos != null) {
                cvProductos.Dispose ();
                cvProductos = null;
            }

            if (imgBanner != null) {
                imgBanner.Dispose ();
                imgBanner = null;
            }

            if (lblTotal != null) {
                lblTotal.Dispose ();
                lblTotal = null;
            }

            if (vwMembresias != null) {
                vwMembresias.Dispose ();
                vwMembresias = null;
            }

            if (vwProductos != null) {
                vwProductos.Dispose ();
                vwProductos = null;
            }
        }
    }
}