using Foundation;
using System;
using UIKit;
using SWRevealViewControllerBinding;


namespace WorklabsMx.iOS
{
    public partial class RegistroInvitadosTableViewController : UITableViewController
    {
        int NumeroCeldasInvitados = 1;
        public RegistroInvitadosTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        partial void btnAñadir_Touch(UIButton sender)
        {
            NumeroCeldasInvitados++;
            TableView.BeginUpdates();
            NSIndexPath newIndexPath = NSIndexPath.FromRowSection(1, 0);
            TableView.InsertRows (new NSIndexPath[]{newIndexPath}, withRowAnimation: UITableViewRowAnimation.Automatic);
            TableView.EndUpdates();
        }


        partial void btnFecha_Tocuh(UIButton sender)
        {
        }

        partial void btnUbicacion_Touch(UIButton sender)
        {
        }

        partial void btnEnviarInvitacion_Touch(UIButton sender)
        {
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (section == 0)
            {
                return NumeroCeldasInvitados;
            }
            else
            {
                return 2;
            }

        }

        /*public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {

        }*/

        partial void btnMenuInvitados_Touch(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }


    }
}