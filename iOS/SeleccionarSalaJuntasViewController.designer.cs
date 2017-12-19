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
    [Register ("SeleccionarSalaJuntasViewController")]
    partial class SeleccionarSalaJuntasViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btAtras { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAdelante { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSalasJuntas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView svSeleccionarSalaJuntas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwVistaSeleccionSalaJuntas { get; set; }

        [Action ("btnAdelante_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAdelante_Touch (UIKit.UIButton sender);

        [Action ("btnAtras_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnAtras_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btAtras != null) {
                btAtras.Dispose ();
                btAtras = null;
            }

            if (btnAdelante != null) {
                btnAdelante.Dispose ();
                btnAdelante = null;
            }

            if (imgSalasJuntas != null) {
                imgSalasJuntas.Dispose ();
                imgSalasJuntas = null;
            }

            if (svSeleccionarSalaJuntas != null) {
                svSeleccionarSalaJuntas.Dispose ();
                svSeleccionarSalaJuntas = null;
            }

            if (vwVistaSeleccionSalaJuntas != null) {
                vwVistaSeleccionSalaJuntas.Dispose ();
                vwVistaSeleccionSalaJuntas = null;
            }
        }
    }
}