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
    [Register ("InfoEmpresaTableViewController")]
    partial class InfoEmpresaTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblEmpresa { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFechaInicioFin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPais { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPuesto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwColaboradores { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwEmpresa { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwEmpresasAnteriores { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblEmpresa != null) {
                lblEmpresa.Dispose ();
                lblEmpresa = null;
            }

            if (lblFechaInicioFin != null) {
                lblFechaInicioFin.Dispose ();
                lblFechaInicioFin = null;
            }

            if (lblPais != null) {
                lblPais.Dispose ();
                lblPais = null;
            }

            if (lblPuesto != null) {
                lblPuesto.Dispose ();
                lblPuesto = null;
            }

            if (vwColaboradores != null) {
                vwColaboradores.Dispose ();
                vwColaboradores = null;
            }

            if (vwEmpresa != null) {
                vwEmpresa.Dispose ();
                vwEmpresa = null;
            }

            if (vwEmpresasAnteriores != null) {
                vwEmpresasAnteriores.Dispose ();
                vwEmpresasAnteriores = null;
            }
        }
    }
}