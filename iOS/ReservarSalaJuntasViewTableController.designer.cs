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
    [Register ("ReservarSalaJuntasViewTableController")]
    partial class ReservarSalaJuntasViewTableController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSeleccionFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView scvScrollHorarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwBotonFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwInfoReservacion { get; set; }

        [Action ("btnSeleccionarFecha_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSeleccionarFecha_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnSeleccionFecha != null) {
                btnSeleccionFecha.Dispose ();
                btnSeleccionFecha = null;
            }

            if (scvScrollHorarios != null) {
                scvScrollHorarios.Dispose ();
                scvScrollHorarios = null;
            }

            if (vwBotonFecha != null) {
                vwBotonFecha.Dispose ();
                vwBotonFecha = null;
            }

            if (vwInfoReservacion != null) {
                vwInfoReservacion.Dispose ();
                vwInfoReservacion = null;
            }
        }
    }
}