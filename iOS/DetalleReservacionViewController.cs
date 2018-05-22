using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;


namespace WorklabsMx.iOS
{
    public partial class DetalleReservacionViewController : UITableViewController
    {
		

		public SalaJuntasModel SalaJuntasSeleccionada;

        public DetalleReservacionViewController (IntPtr handle) : base (handle)
        {
			
        }

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if(segue.Identifier == "Confirmacion")
			{
				
			}
		}

		partial void btnRetroceder_Touch(UIButton sender)
		{
			var controller = Storyboard.InstantiateViewController("SeleccionarSalaTableView");
            this.NavigationController.PushViewController(controller, true);
		}

		partial void btnAvanzar_Touch(UIButton sender)
		{
			this.PerformSegue("Confirmacion", null);
		}
	}
}