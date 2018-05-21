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
		private string HoraInicio = "";
		private string HoraInicioSeleccionada = "";
		private string HoraFin = "";
		private string HoraFinSeleccionada = "";
		private string MinutosInicio = "";
		private string MinutosFin = "";
		private string FechaSeleccionada;
		private string CantidadPersonas = "";
		private List<UIButton> BotonesHoraInicio = new List<UIButton>();
		private List<UIButton> BotonesHoraFin = new List<UIButton>();
		private List<SalaJuntasModel> SalasJuntas = new List<SalaJuntasModel>();
		private List<string> HorasInicio = new List<string>();
		private List<string> HorasFin = new List<string>();
		private List<string> Personas = new List<string>();
		private int HoraActual = DateTime.Now.Hour;

		NSDateFormatter dateFormat = new NSDateFormatter();

		public FechaHoraSalaViewController (IntPtr handle) : base (handle)
        {
			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.dtpFecha.Date = NSDate.Now;
			this.dtpFecha.MinimumDate = NSDate.Now;
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

        private void ListadoHoraInicio(int Hora)
		{
			for (int Indice = Hora + 1; Indice < 24; Indice++)
            {
                HorasInicio.Add(Indice.ToString());
            }
		}

		private void ListadoHoraFin(int Hora)
        {
			for (int Indice = Hora + 1; Indice < 24; Indice++)
            {
                HorasFin.Add(Indice.ToString());
            }
        }

		partial void btnRetroceder_Touch(UIButton sender)
		{
			var controller = Storyboard.InstantiateViewController("InicioSalaJuntasView");
			this.NavigationController.PushViewController(controller, true);
		}

		partial void btnAvanzar_Touch(UIButton sender)
		{

			if (this.HoraInicio == "")
			{
				new MessageDialog().SendToast("Por favor selecciona una hora de inicio");
			}
			else if (this.MinutosInicio == "")
			{
				new MessageDialog().SendToast("Por favor selecciona los minutos de la hora de inicio");
			}
			else if (this.HoraFin == "")
			{
				new MessageDialog().SendToast("Por favor selecciona una hora fin");
			}
			else if (this.MinutosFin == "")
			{
				new MessageDialog().SendToast("Por favor selecciona los minutos de la hora fin");
			}
			else if (this.CantidadPersonas == "")
			{
				new MessageDialog().SendToast("Por favor selecciona la cantidad de personas que necesitas para tu reunión");
			}
			else
			{
				this.SalasJuntas = new SalasJuntasController().GetSalaJuntas("1", this.FechaSeleccionada, this.HoraInicio, this.HoraFin, this.CantidadPersonas);
				this.PerformSegue("SeleccionarSalaSegue", null);
			}


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
			this.HoraInicio = this.HoraInicioSeleccionada + ":" + this.MinutosInicio;
		}

		partial void HoraFinTreinta_Touch(UIButton sender)
		{
			this.MinutosFin = "30";
			this.btnMinutosFinTr.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosFin.BackgroundColor = UIColor.Clear.FromHex(0x000000);
			this.HoraFin = this.HoraFinSeleccionada + ":" + this.MinutosFin;
		}

		partial void HoraFinCero_Touch(UIButton sender)
		{
			this.MinutosFin = "00";
			this.btnMinutosFin.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosFinTr.BackgroundColor = UIColor.Clear.FromHex(0x000000);
			this.HoraFin = this.HoraFinSeleccionada + ":" + this.MinutosFin;
		}

		partial void HoraInicioTreinta_Touch(UIButton sender)
		{
			this.MinutosInicio = "30";
			this.btnMinutosTreinta.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosCero.BackgroundColor = UIColor.Clear.FromHex(0x000000);
			this.HoraInicio = this.HoraInicioSeleccionada + ":" + this.MinutosInicio;
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "SeleccionarSalaSegue")
			{
				var VistaSalas = (SeleccionarSalaTableView)segue.DestinationViewController.ChildViewControllers[0];
				VistaSalas.SalasJuntas = this.SalasJuntas;
			}
			else if (segue.Identifier == "HoraInicioReservacion")
			{
				var VistaHoraInicio = (HoraInicioCollectionView)segue.DestinationViewController;
				this.ListadoHoraFin(this.HoraActual);
				VistaHoraInicio.Horas = this.HorasFin;
				VistaHoraInicio.HoraInicioDelegate = this;

			}
			else if (segue.Identifier == "HoraFinReservacion")
			{
				var VistaHoraFin = (HoraFinCollectionView)segue.DestinationViewController;
				this.ListadoHoraInicio(this.HoraActual);
				VistaHoraFin.Horas = this.HorasInicio;
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
			this.HoraInicioSeleccionada = HoraInicioSeleccionada;
			this.HoraInicio = this.HoraInicioSeleccionada + ":" + this.MinutosInicio;
		}

		public void SeleccionarHoraFin(string HoraFinSeleccionada)
		{
			if (HoraFinSeleccionada.Length == 1)
            {
				HoraFinSeleccionada = "0" + HoraFinSeleccionada;
            }
			this.HoraFinSeleccionada = HoraFinSeleccionada;
			this.HoraFin = this.HoraFinSeleccionada + ":" + this.MinutosFin;
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