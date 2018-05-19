using Foundation;
using System;
using UIKit;
using CoreGraphics;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.Controllers;

namespace WorklabsMx.iOS
{
    public partial class FechaHoraSalaViewController : UITableViewController
    {
		private string HoraInicio;
		private string HoraFin;
		private string MinutosInicio;
		private string MinutosFin;
		private string FechaSeleccionada;
		private string CantidadPersonas;
		private List<UIButton> BotonesHoraInicio = new List<UIButton>();
		private List<UIButton> BotonesHoraFin = new List<UIButton>();
		private List<SalaJuntasModel> SalasJuntas = new List<SalaJuntasModel>();
		private List<string> Horas = new List<string>();
		private List<string> Personas = new List<string>();
		NSDateFormatter dateFormat = new NSDateFormatter();

		public FechaHoraSalaViewController (IntPtr handle) : base (handle)
        {
			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            for (int Indice = 1; Indice <= 24; Indice++)
            {
                Horas.Add(Indice.ToString());
            }

			for (int Indice = 1; Indice <= 10; Indice++)
			{
				Personas.Add(Indice.ToString());
			}

			dateFormat.DateFormat = "yyyy-MM-dd";
			this.FechaSeleccionada = dateFormat.ToString(dtpFecha.Date);
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

		}

		partial void btnRetroceder_Touch(UIButton sender)
		{
			var controller = Storyboard.InstantiateViewController("InicioSalaJuntasView");
			this.NavigationController.PushViewController(controller, true);
		}

		partial void btnAvanzar_Touch(UIButton sender)
		{
			this.SalasJuntas = new SalasJuntasController().GetSalaJuntas("0" , this.FechaSeleccionada, this.HoraInicio, this.HoraFin, this.CantidadPersonas);
			this.PerformSegue("SeleccionarSala", null);
		}
      
		partial void dtpFecha_Cahnged(UIDatePicker sender)
		{
			this.FechaSeleccionada = dateFormat.ToString(sender.Date);
		}

		partial void HoraInicioCero_Touch(UIButton sender)
		{
			this.MinutosInicio = "00";
			this.btnMinutosCero.BackgroundColor =UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosTreinta.BackgroundColor = UIColor.Clear.FromHex(0x000000);
		}

		partial void HoraFinTreinta_Touch(UIButton sender)
		{
			this.MinutosFin = "30";
			this.btnMinutosFinTr.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosFin.BackgroundColor = UIColor.Clear.FromHex(0x000000);
		}

		partial void HoraFinCero_Touch(UIButton sender)
		{
			this.MinutosFin = "00";
			this.btnMinutosFin.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosFinTr.BackgroundColor = UIColor.Clear.FromHex(0x000000);
		}

		partial void HoraInicioTreinta_Touch(UIButton sender)
		{
			this.MinutosInicio = "30";
			this.btnMinutosTreinta.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosCero.BackgroundColor = UIColor.Clear.FromHex(0x000000);
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "SeleccionarSala")
			{
				var VistaSalas = (SeleccionarSalaTableView)segue.DestinationViewController;
				VistaSalas.SalasJuntas = this.SalasJuntas;
			}
			else if (segue.Identifier == "HoraInicioReservacion")
			{
				var VistaHoraInicio = (HoraInicioCollectionView)segue.DestinationViewController;
				VistaHoraInicio.Horas = this.Horas;
				VistaHoraInicio.HoraInicioDelegate = this;

			}
			else if (segue.Identifier == "HoraFinReservacion")
			{
				var VistaHoraFin = (HoraFinCollectionView)segue.DestinationViewController;
				VistaHoraFin.Horas = this.Horas;
				VistaHoraFin.HoraFinDelegate = this;
			}
            else if (segue.Identifier == "CantidadPersonas")
			{
				var VistaCantidadPersonas = (CantidadPersonasCollection)segue.DestinationViewController;
				VistaCantidadPersonas.CantidadPersonas = this.Personas;
				VistaCantidadPersonas.CantidadPersonasDelegate = this;
			}
		}
	}

	public partial class FechaHoraSalaViewController : HoraSeleccionada
	{
		public void SeleccionarHoraInicio(string HoraInicioSeleccionada)
		{
			if(HoraInicioSeleccionada.Length == 1)
			{
				HoraInicioSeleccionada = "0" + HoraInicioSeleccionada;
			}
			this.HoraInicio = HoraInicioSeleccionada + ":" + this.MinutosInicio;
		}

		public void SeleccionarHoraFin(string HoraFinSeleccionada)
		{
			if (HoraFinSeleccionada.Length == 1)
            {
				HoraFinSeleccionada = "0" + HoraFinSeleccionada;
            }
			this.HoraFin = HoraFinSeleccionada + ":" + this.MinutosFin;
		}
	}

	public partial class FechaHoraSalaViewController : CantidadPersonasSeleccionadas
	{
		public void SeleccionarCantidadPersonas(string CantidadPersonas)
		{
			this.CantidadPersonas = CantidadPersonas;
		}
	}



}