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
    [Register ("PublicarPostViewController")]
    partial class PublicarPostViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnClose { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnDeleteImge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnGaleria { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnImageComment { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPublicar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgPerfil { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaPublicacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblOcupacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtPublicacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwVistaComentar { get; set; }

        [Action ("btnClose_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnClose_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnDeleteImage_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnDeleteImage_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnGaleria_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnGaleria_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnImageComment_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnImageComment_TouchUpInside (UIKit.UIButton sender);

        [Action ("btnPublicar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnPublicar_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnClose != null) {
                btnClose.Dispose ();
                btnClose = null;
            }

            if (btnDeleteImge != null) {
                btnDeleteImge.Dispose ();
                btnDeleteImge = null;
            }

            if (btnGaleria != null) {
                btnGaleria.Dispose ();
                btnGaleria = null;
            }

            if (btnImageComment != null) {
                btnImageComment.Dispose ();
                btnImageComment = null;
            }

            if (btnPublicar != null) {
                btnPublicar.Dispose ();
                btnPublicar = null;
            }

            if (imgPerfil != null) {
                imgPerfil.Dispose ();
                imgPerfil = null;
            }

            if (lblFechaPublicacion != null) {
                lblFechaPublicacion.Dispose ();
                lblFechaPublicacion = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }

            if (lblOcupacion != null) {
                lblOcupacion.Dispose ();
                lblOcupacion = null;
            }

            if (txtPublicacion != null) {
                txtPublicacion.Dispose ();
                txtPublicacion = null;
            }

            if (vwVistaComentar != null) {
                vwVistaComentar.Dispose ();
                vwVistaComentar = null;
            }
        }
    }
}