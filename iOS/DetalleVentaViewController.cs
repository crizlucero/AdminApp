using System;
using Foundation;
using UIKit;
using WorklabsMx.iOS.Models;
using System.Collections.Generic;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;
using WorklabsMx.Enum;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;
using BigTed;
using System.Threading.Tasks;


namespace WorklabsMx.iOS
{
    public partial class DetalleVentaViewController : UIViewController
    {

        public CarritoCompras Venta;

        public DetalleVentaViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            StyleHelper.Style(vwDetalleProducto.Layer);
        }

        partial void btnBack_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }
    }
}