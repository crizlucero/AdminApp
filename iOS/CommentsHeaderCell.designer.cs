// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WorklabsMx.iOS
{
	[Register ("CommentsHeaderCell")]
	partial class CommentsHeaderCell
	{
		[Outlet]
		UIKit.UIImageView imgProfile { get; set; }

		[Outlet]
		UIKit.UILabel lblNombre { get; set; }

		[Outlet]
		UIKit.UILabel lblProfecion { get; set; }

		[Action ("btnPublicar:")]
		partial void btnPublicar (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (lblNombre != null) {
				lblNombre.Dispose ();
				lblNombre = null;
			}

			if (lblProfecion != null) {
				lblProfecion.Dispose ();
				lblProfecion = null;
			}

			if (imgProfile != null) {
				imgProfile.Dispose ();
				imgProfile = null;
			}
		}
	}
}
