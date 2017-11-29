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
    [Register ("DireccionEmpresaTableViewController")]
    partial class DireccionEmpresaTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEditarColonia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCalle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCodigoPostal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtColonia { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEstado { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtMunicipio { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNumeroExterior { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNumeroInterior { get; set; }

        [Action ("btnEditarColonia_TouchupInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnEditarColonia_TouchupInside (UIKit.UIButton sender);

        [Action ("btnGuardar:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnGuardar (UIKit.UIBarButtonItem sender);

        [Action ("txtCodigoPostal_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void txtCodigoPostal_ValueChanged (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnEditarColonia != null) {
                btnEditarColonia.Dispose ();
                btnEditarColonia = null;
            }

            if (txtCalle != null) {
                txtCalle.Dispose ();
                txtCalle = null;
            }

            if (txtCodigoPostal != null) {
                txtCodigoPostal.Dispose ();
                txtCodigoPostal = null;
            }

            if (txtColonia != null) {
                txtColonia.Dispose ();
                txtColonia = null;
            }

            if (txtEstado != null) {
                txtEstado.Dispose ();
                txtEstado = null;
            }

            if (txtMunicipio != null) {
                txtMunicipio.Dispose ();
                txtMunicipio = null;
            }

            if (txtNumeroExterior != null) {
                txtNumeroExterior.Dispose ();
                txtNumeroExterior = null;
            }

            if (txtNumeroInterior != null) {
                txtNumeroInterior.Dispose ();
                txtNumeroInterior = null;
            }
        }
    }
}