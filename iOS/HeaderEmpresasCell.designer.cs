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
    [Register ("HeaderEmpresasCell")]
    partial class HeaderEmpresasCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtBuscarEmpresa { get; set; }

        [Action ("txtBuscarEmpresa_Chang:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void txtBuscarEmpresa_Chang (UIKit.UITextField sender);

        [Action ("txtEmpresaBuscador_Touch:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void txtEmpresaBuscador_Touch (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (txtBuscarEmpresa != null) {
                txtBuscarEmpresa.Dispose ();
                txtBuscarEmpresa = null;
            }
        }
    }
}