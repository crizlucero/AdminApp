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
    [Register ("FavoritosTableViewCell")]
    partial class FavoritosTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnImagenFavoritos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNombre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblProfesion { get; set; }

        [Action ("btnImagenFav_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnImagenFav_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnImagenFavoritos != null) {
                btnImagenFavoritos.Dispose ();
                btnImagenFavoritos = null;
            }

            if (lblNombre != null) {
                lblNombre.Dispose ();
                lblNombre = null;
            }

            if (lblProfesion != null) {
                lblProfesion.Dispose ();
                lblProfesion = null;
            }
        }
    }
}