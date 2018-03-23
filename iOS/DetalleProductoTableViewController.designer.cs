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
    [Register ("DetalleProductoTableViewController")]
    partial class DetalleProductoTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAgregar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAñadir { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnDetalle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnQuitar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSucursales { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgProducto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDetalleDescripcion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLeyenda { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPrecio { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCantidad { get; set; }

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

        [Action ("btnCerrar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnCerrar_Touch (UIKit.UIBarButtonItem sender);

        [Action ("btnDeatlle_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnDeatlle_Touch (UIKit.UIButton sender);

        [Action ("btnDetalle_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnDetalle_Touch (UIKit.UIButton sender);

        [Action ("btnFecha_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnFecha_Touch (UIKit.UIButton sender);

        [Action ("btnQuitar_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnQuitar_Touch (UIKit.UIButton sender);

        [Action ("btnSucursales_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSucursales_Touch (UIKit.UIButton sender);

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

            if (btnDetalle != null) {
                btnDetalle.Dispose ();
                btnDetalle = null;
            }

            if (btnFecha != null) {
                btnFecha.Dispose ();
                btnFecha = null;
            }

            if (btnQuitar != null) {
                btnQuitar.Dispose ();
                btnQuitar = null;
            }

            if (btnSucursales != null) {
                btnSucursales.Dispose ();
                btnSucursales = null;
            }

            if (imgProducto != null) {
                imgProducto.Dispose ();
                imgProducto = null;
            }

            if (lblDetalleDescripcion != null) {
                lblDetalleDescripcion.Dispose ();
                lblDetalleDescripcion = null;
            }

            if (lblLeyenda != null) {
                lblLeyenda.Dispose ();
                lblLeyenda = null;
            }

            if (lblPrecio != null) {
                lblPrecio.Dispose ();
                lblPrecio = null;
            }

            if (txtCantidad != null) {
                txtCantidad.Dispose ();
                txtCantidad = null;
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