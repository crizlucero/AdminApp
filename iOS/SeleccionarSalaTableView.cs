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

		public string HoraInicio;
		public string HoraFin;
		public string FechaSeleccionada;
		public float HorasReservadas;
		private float CreditosAcumulados;

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

		private void CalcularCreditosSeleccionados()
		{
			var intHoraInicio = float.Parse(this.HoraInicio.Split(':')[0]);
			var intHoraFin = float.Parse(this.HoraFin.Split(':')[0]);
			if (SalaJuntasSeleccionada.Sala_Id != null && SalaJuntasSeleccionada.Sala_Id != "")
            {
                for (float Hora = intHoraInicio; Hora < intHoraFin; Hora = Hora + 0.5f)
                {
					if (Hora >= 11 && Hora <= 17 && SalaJuntasSeleccionada.Sala_Capacidad == "10")
                    {
                        this.CreditosAcumulados = this.CreditosAcumulados + 1.5f;
                    }
                    else
                    {
                        this.CreditosAcumulados = this.CreditosAcumulados + 1;
                    }
                }
            }
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if(segue.Identifier == "VerSala")
			{
				var VistaSalas = (SalasCollectionView)segue.DestinationViewController;
				VistaSalas.SalasJuntas = this.SalasJuntas;
				VistaSalas.SalaSeleccionadaDelegate = this;
			}
			else if(segue.Identifier == "DetalleReservacion")
			{
				var VistaDetalleReservacion = (DetalleReservacionViewController)segue.DestinationViewController.ChildViewControllers[0];
				VistaDetalleReservacion.SalaJuntasSeleccionada = this.SalaJuntasSeleccionada;
				VistaDetalleReservacion.HoraInicio = this.HoraInicio;
				VistaDetalleReservacion.HoraFin = this.HoraFin;
				VistaDetalleReservacion.FechaSeleccionada = this.FechaSeleccionada;
				VistaDetalleReservacion.HorasReservadas = this.HorasReservadas;
				VistaDetalleReservacion.CreditosAcumulados = this.CreditosAcumulados;
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
			this.CalcularCreditosSeleccionados();
			this.PerformSegue("DetalleReservacion", null);
		}
	}
}