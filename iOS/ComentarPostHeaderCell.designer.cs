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
    [Register ("ComentarPostHeaderCell")]
    partial class ComentarPostHeaderCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtComentarPost { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vwComentarPost { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (txtComentarPost != null) {
                txtComentarPost.Dispose ();
                txtComentarPost = null;
            }

            if (vwComentarPost != null) {
                vwComentarPost.Dispose ();
                vwComentarPost = null;
            }
        }
    }
}