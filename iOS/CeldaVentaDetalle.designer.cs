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
	[Register ("CeldaVentaDetalle")]
	partial class CeldaVentaDetalle
	{
		[Outlet]
		UIKit.UILabel lblCantidad { get; set; }

		[Outlet]
		UIKit.UILabel lblNombreProducto { get; set; }

		[Outlet]
		UIKit.UILabel lblTotalPagar { get; set; }

		[Outlet]
		UIKit.UIView vwVistaDetalleVenta { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblCantidad != null) {
				lblCantidad.Dispose ();
				lblCantidad = null;
			}

			if (lblNombreProducto != null) {
				lblNombreProducto.Dispose ();
				lblNombreProducto = null;
			}

			if (lblTotalPagar != null) {
				lblTotalPagar.Dispose ();
				lblTotalPagar = null;
			}

			if (vwVistaDetalleVenta != null) {
				vwVistaDetalleVenta.Dispose ();
				vwVistaDetalleVenta = null;
			}
		}
	}
}
