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
    [Register ("BuscadorTableViewCell")]
    partial class BuscadorTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchBar srbComunidad { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (srbComunidad != null) {
                srbComunidad.Dispose ();
                srbComunidad = null;
            }
        }
    }
}