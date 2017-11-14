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
	[Register ("VentaDetalleHeader")]
	partial class VentaDetalleHeader
	{
		[Outlet]
		UIKit.UIButton btnUsarCupon { get; set; }

		[Outlet]
		UIKit.UILabel lblDescuento { get; set; }

		[Outlet]
		UIKit.UILabel lblImpuesto { get; set; }

		[Outlet]
		UIKit.UILabel lblSubtotal { get; set; }

		[Outlet]
		UIKit.UILabel lblTotal { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblDescuento != null) {
				lblDescuento.Dispose ();
				lblDescuento = null;
			}

			if (lblImpuesto != null) {
				lblImpuesto.Dispose ();
				lblImpuesto = null;
			}

			if (lblSubtotal != null) {
				lblSubtotal.Dispose ();
				lblSubtotal = null;
			}

			if (lblTotal != null) {
				lblTotal.Dispose ();
				lblTotal = null;
			}

			if (btnUsarCupon != null) {
				btnUsarCupon.Dispose ();
				btnUsarCupon = null;
			}
		}
	}
}
