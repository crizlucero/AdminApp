using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class PagosTableViewController: UITableViewController
    {

        public PagosTableViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            EjemploPagos objPagos = new EjemploPagos();
            objPagos.Pagar(this);
        }


    }




}