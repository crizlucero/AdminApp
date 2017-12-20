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
        UIKit.UIImageView imgSalasJuntas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPageControl pcSucursales { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView scvSalasJuntas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView scvScrollHorarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwBotonFecha { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwHorarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwInfoReservacion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwSalasJuntas { get; set; }

        [Action ("btnSeleccionarFecha_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSeleccionarFecha_Touch (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnSeleccionFecha != null) {
                btnSeleccionFecha.Dispose ();
                btnSeleccionFecha = null;
            }

            if (imgSalasJuntas != null) {
                imgSalasJuntas.Dispose ();
                imgSalasJuntas = null;
            }

            if (pcSucursales != null) {
                pcSucursales.Dispose ();
                pcSucursales = null;
            }

            if (scvSalasJuntas != null) {
                scvSalasJuntas.Dispose ();
                scvSalasJuntas = null;
            }

            if (scvScrollHorarios != null) {
                scvScrollHorarios.Dispose ();
                scvScrollHorarios = null;
            }

            if (vwBotonFecha != null) {
                vwBotonFecha.Dispose ();
                vwBotonFecha = null;
            }

            if (vwHorarios != null) {
                vwHorarios.Dispose ();
                vwHorarios = null;
            }

            if (vwInfoReservacion != null) {
                vwInfoReservacion.Dispose ();
                vwInfoReservacion = null;
            }

            if (vwSalasJuntas != null) {
                vwSalasJuntas.Dispose ();
                vwSalasJuntas = null;
            }
        }
    }
}