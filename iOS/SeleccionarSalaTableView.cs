using Foundation;
using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Models;
using WorklabsMx.Models;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class SeleccionarSalaTableView : UITableViewController
    {
		
		public List<SalaJuntasModel> SalasJuntas = new List<SalaJuntasModel>();

		SalaJuntasModel SalaJuntasSeleccionada = new SalaJuntasModel();

        public SeleccionarSalaTableView (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if(segue.Identifier == "VerSala")
			{
				var VistaSalas = (SalasCollectionView)segue.DestinationViewController;
				VistaSalas.SalasJuntas = this.SalasJuntas;
				VistaSalas.SalaSeleccionadaDelegate = this;

			}

		}

		partial void btnRetroceder_Touch(UIButton sender)
		{
			var controller = Storyboard.InstantiateViewController("FechaHoraSalaViewController");
            this.NavigationController.PushViewController(controller, true);
		}
	}

	public partial class SeleccionarSalaTableView : SalaSeleccionada
	{
		public void SalaSeleccionada(SalaJuntasModel SalaSeleccionada)
		{
			this.SalaJuntasSeleccionada = SalaSeleccionada;
			this.PerformSegue("DetalleSala", null);
		}
	}
}