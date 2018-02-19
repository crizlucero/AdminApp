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
    [Register ("EditarMiInfoPerfilViewController")]
    partial class EditarMiInfoPerfilViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAgregarHabilidad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAgregarInteres { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFechaNacimiento { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvwHabilidades { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView cvwIntereses { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCelular { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtHabilidad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtInteres { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtMiInfo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtTelefono { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwCelular { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwHabilidades { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwIntereses { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwMiInfo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwTelefono { get; set; }

        [Action ("btnAgregarHabilad_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAgregarHabilad_Touch (UIKit.UIButton sender);

        [Action ("btnAgregarInteres_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAgregarInteres_Touch (UIKit.UIButton sender);

        [Action ("BtnFechaNacimiento_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnFechaNacimiento_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAgregarHabilidad != null) {
                btnAgregarHabilidad.Dispose ();
                btnAgregarHabilidad = null;
            }

            if (btnAgregarInteres != null) {
                btnAgregarInteres.Dispose ();
                btnAgregarInteres = null;
            }

            if (btnFechaNacimiento != null) {
                btnFechaNacimiento.Dispose ();
                btnFechaNacimiento = null;
            }

            if (cvwHabilidades != null) {
                cvwHabilidades.Dispose ();
                cvwHabilidades = null;
            }

            if (cvwIntereses != null) {
                cvwIntereses.Dispose ();
                cvwIntereses = null;
            }

            if (txtCelular != null) {
                txtCelular.Dispose ();
                txtCelular = null;
            }

            if (txtEmail != null) {
                txtEmail.Dispose ();
                txtEmail = null;
            }

            if (txtHabilidad != null) {
                txtHabilidad.Dispose ();
                txtHabilidad = null;
            }

            if (txtInteres != null) {
                txtInteres.Dispose ();
                txtInteres = null;
            }

            if (txtMiInfo != null) {
                txtMiInfo.Dispose ();
                txtMiInfo = null;
            }

            if (txtTelefono != null) {
                txtTelefono.Dispose ();
                txtTelefono = null;
            }

            if (vwCelular != null) {
                vwCelular.Dispose ();
                vwCelular = null;
            }

            if (vwEmail != null) {
                vwEmail.Dispose ();
                vwEmail = null;
            }

            if (vwHabilidades != null) {
                vwHabilidades.Dispose ();
                vwHabilidades = null;
            }

            if (vwIntereses != null) {
                vwIntereses.Dispose ();
                vwIntereses = null;
            }

            if (vwMiInfo != null) {
                vwMiInfo.Dispose ();
                vwMiInfo = null;
            }

            if (vwTelefono != null) {
                vwTelefono.Dispose ();
                vwTelefono = null;
            }
        }
    }
}