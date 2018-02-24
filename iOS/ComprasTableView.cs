using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using BigTed;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Models;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class ComprasTableView : UITableViewController
    {

        public ComprasTableView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.cvProductos.Hidden = false;
            this.cvMembresias.Hidden = true;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        partial void sclCompras_Changed(UISegmentedControl sender)
        {
            if (sclCompras.SelectedSegment == 0)
            {
                this.cvProductos.Hidden = false;
                this.cvMembresias.Hidden = true;
            }
            else
            {
                this.cvProductos.Hidden = true;
                this.cvMembresias.Hidden = false;
            }
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "Productos")
            {
                var VistaColeccionProductos = (ColeccionProductos)segue.DestinationViewController;
                VistaColeccionProductos.allProducts = MenuHelper.Productos;
            }
            else if (segue.Identifier == "Membresias")
            {
                var VistaColeccionMembresias = (ColeccionMembresias)segue.DestinationViewController;
                VistaColeccionMembresias.allMembresias = MenuHelper.Membresias;
            }
        }

        partial void btnAtras_Touch(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }
    }
}