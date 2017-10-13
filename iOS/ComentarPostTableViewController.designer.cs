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
    [Register ("ComentarPostTableViewController")]
    partial class ComentarPostTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwSeccionComentarios { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwVistaSeccionComentarios { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (vwSeccionComentarios != null) {
                vwSeccionComentarios.Dispose ();
                vwSeccionComentarios = null;
            }

            if (vwVistaSeccionComentarios != null) {
                vwVistaSeccionComentarios.Dispose ();
                vwVistaSeccionComentarios = null;
            }
        }
    }
}