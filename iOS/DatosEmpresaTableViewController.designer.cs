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
    [Register ("DatosEmpresaTableViewController")]
    partial class DatosEmpresaTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnActualizarEmpresa { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEditarDireccion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEditarRedesSociales { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton imgCamara { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCorreoElectronico { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtGiroComercial { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNombreEmpresa { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtRazonSocial { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtRFC { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtTelefono { get; set; }

        [Action ("btnActualizar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnActualizar_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnEditarDireccion_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnEditarDireccion_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnRedesSociales_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnRedesSociales_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnTomarFoto_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnTomarFoto_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnActualizarEmpresa != null) {
                btnActualizarEmpresa.Dispose ();
                btnActualizarEmpresa = null;
            }

            if (btnEditarDireccion != null) {
                btnEditarDireccion.Dispose ();
                btnEditarDireccion = null;
            }

            if (btnEditarRedesSociales != null) {
                btnEditarRedesSociales.Dispose ();
                btnEditarRedesSociales = null;
            }

            if (imgCamara != null) {
                imgCamara.Dispose ();
                imgCamara = null;
            }

            if (imgPerfil != null) {
                imgPerfil.Dispose ();
                imgPerfil = null;
            }

            if (txtCorreoElectronico != null) {
                txtCorreoElectronico.Dispose ();
                txtCorreoElectronico = null;
            }

            if (txtGiroComercial != null) {
                txtGiroComercial.Dispose ();
                txtGiroComercial = null;
            }

            if (txtNombreEmpresa != null) {
                txtNombreEmpresa.Dispose ();
                txtNombreEmpresa = null;
            }

            if (txtRazonSocial != null) {
                txtRazonSocial.Dispose ();
                txtRazonSocial = null;
            }

            if (txtRFC != null) {
                txtRFC.Dispose ();
                txtRFC = null;
            }

            if (txtTelefono != null) {
                txtTelefono.Dispose ();
                txtTelefono = null;
            }
        }
    }
}