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
            TableView.BeginUpdates();
            NSIndexPath newIndexPath = NSIndexPath.FromRowSection(NumeroCeldasInvitados, 0);
            //TableView.InsertRows(new NSIndexPath[] { NSIndexPath.FromRowSection(0, 0) }, UITableViewRowAnimation.Fade);
            TableView.InsertRows (new NSIndexPath[]{newIndexPath}, withRowAnimation: UITableViewRowAnimation.Automatic);        

            NumeroCeldasInvitados++;
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
                return base.RowsInSection(TableView, section);
            }
        }

        partial void btnMenuInvitados_Touch(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }
    }
}