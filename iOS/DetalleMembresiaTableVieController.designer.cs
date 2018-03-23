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
    [Register ("DetalleMembresiaTableVieController")]
    partial class DetalleMembresiaTableVieController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAgregar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAñadir { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnCarrito { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnClose { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UINavigationItem btnComprar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnDeatlle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnQuitar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSucursal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgMembresia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDescripcion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLeyenda { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPrecio { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCantidadMembresias { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwSucursales { get; set; }

        [Action ("btnAgregar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAgregar_Touch (UIKit.UIButton sender);

        [Action ("btnAñadir_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAñadir_Touch (UIKit.UIButton sender);

        [Action ("btnCarrito_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCarrito_Touch (UIKit.UIBarButtonItem sender);

        [Action ("btnCerrar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCerrar_Touch (UIKit.UIBarButtonItem sender);

        [Action ("btnDetalle_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnDetalle_Touch (UIKit.UIButton sender);

        [Action ("btnFecha_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnFecha_Touch (UIKit.UIButton sender);

        [Action ("btnQuitar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnQuitar_Touch (UIKit.UIButton sender);

        [Action ("btnSucursal_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSucursal_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAgregar != null) {
                btnAgregar.Dispose ();
                btnAgregar = null;
            }

            if (btnAñadir != null) {
                btnAñadir.Dispose ();
                btnAñadir = null;
            }

            if (btnCarrito != null) {
                btnCarrito.Dispose ();
                btnCarrito = null;
            }

            if (btnClose != null) {
                btnClose.Dispose ();
                btnClose = null;
            }

            if (btnComprar != null) {
                btnComprar.Dispose ();
                btnComprar = null;
            }

            if (btnDeatlle != null) {
                btnDeatlle.Dispose ();
                btnDeatlle = null;
            }

            if (btnFecha != null) {
                btnFecha.Dispose ();
                btnFecha = null;
            }

            if (btnQuitar != null) {
                btnQuitar.Dispose ();
                btnQuitar = null;
            }

            if (btnSucursal != null) {
                btnSucursal.Dispose ();
                btnSucursal = null;
            }

            if (imgMembresia != null) {
                imgMembresia.Dispose ();
                imgMembresia = null;
            }

            if (lblDescripcion != null) {
                lblDescripcion.Dispose ();
                lblDescripcion = null;
            }

            if (lblLeyenda != null) {
                lblLeyenda.Dispose ();
                lblLeyenda = null;
            }

            if (lblPrecio != null) {
                lblPrecio.Dispose ();
                lblPrecio = null;
            }

            if (txtCantidadMembresias != null) {
                txtCantidadMembresias.Dispose ();
                txtCantidadMembresias = null;
            }

            if (vwFecha != null) {
                vwFecha.Dispose ();
                vwFecha = null;
            }

            if (vwSucursales != null) {
                vwSucursales.Dispose ();
                vwSucursales = null;
            }
        }
    }
}