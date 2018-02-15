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
    [Register ("CeldaTrabajosAnteriores")]
    partial class CeldaTrabajosAnteriores
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgEmpresaLogo { get; set; }

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

        void ReleaseDesignerOutlets ()
        {
            if (imgEmpresaLogo != null) {
                imgEmpresaLogo.Dispose ();
                imgEmpresaLogo = null;
            }

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
        }
    }
}