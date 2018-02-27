using Foundation;
using System;
using UIKit;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class AcercaDeViewController : UITableViewController
    {
        public AcercaDeViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.lblVersion.Text = "Worklabs 1.1.1";
            this.lblAutor.Text = "Autor: Espacio Claro";
            this.lblCopyrigth.Text = "Copyright 2018";
        }

        partial void btnAtras(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }
    }
}