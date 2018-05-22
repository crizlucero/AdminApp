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
		private float HorasReservadas;
		private UIStoryboardSegue segueSegueHoraInicio;
		private UIStoryboardSegue segueSegueHoraFin;
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
			this.HorasInicio = new List<string>();
			for (int Indice = Hora + 1; Indice < 24; Indice++)
            {
                HorasInicio.Add(Indice.ToString());
            }
		}

		private void ListadoHoraFin(int Hora)
        {
			this.HorasFin = new List<string>();
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

        private bool ValidarHorasSeleccionadas()
		{
			int HoraIni = int.Parse(this.HoraInicio.Split(':')[0]);
			int HoraFn = int.Parse(this.HoraFin.Split(':')[0]);

			if(HoraIni == HoraFn)
			{
				if (this.MinutosFin == "00" || this.MinutosInicio == "30")
				{
					return true;
				}
				return false;
			}

			if (HoraIni > HoraFn)
			{
				return true;
			}
			return false;
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
			else if(this.ValidarHorasSeleccionadas())
			{
				new MessageDialog().SendToast("Seleccionaste una hora inicial mayor a la hora fin");
			}
			else
			{
				this.SalasJuntas = new SalasJuntasController().GetSalaJuntas("1", this.FechaSeleccionada, this.HoraInicio, this.HoraFin, this.CantidadPersonas);
				if (this.SalasJuntas.Count == 0)
				{
					new MessageDialog().SendToast("No hay salas de reunios disponibles para esa fecha y horario");
				}
                else
				{
					this.PerformSegue("SeleccionarSalaSegue", null);
				}

			}
		}
      

		partial void dtpFecha_Cahnged(UIDatePicker sender)
		{
			this.FechaSeleccionada = dateFormat.ToString(sender.Date);
			if (this.FechaSeleccionada != dateFormat.ToString(NSDate.Now))
			{
				this.HoraActual = 0;
			}
			else
			{
				this.HoraActual = DateTime.Now.Hour;
			}
			this.PrepareForSegue(segueSegueHoraFin, null);
            this.PrepareForSegue(segueSegueHoraInicio, null);

		}

		partial void HoraInicioCero_Touch(UIButton sender)
		{
			this.MinutosInicio = "00";
			this.btnMinutosCero.BackgroundColor =UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosTreinta.BackgroundColor = UIColor.Clear.FromHex(0x000000);
			this.HoraInicio = this.HoraInicioSeleccionada + ":" + this.MinutosInicio;
			if (this.HoraFinSeleccionada != "" && this.MinutosFin != "")
			{
				this.CalcularHorasReservadas(this.HoraInicio, this.HoraFin);
			}

		}

		partial void HoraFinTreinta_Touch(UIButton sender)
		{
			this.MinutosFin = "30";
			this.btnMinutosFinTr.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosFin.BackgroundColor = UIColor.Clear.FromHex(0x000000);
			this.HoraFin = this.HoraFinSeleccionada + ":" + this.MinutosFin;

			if (this.HoraFinSeleccionada != "" && this.MinutosInicio != "")
			{
				this.CalcularHorasReservadas(this.HoraInicio, this.HoraFin);
			}
		}

		partial void HoraFinCero_Touch(UIButton sender)
		{
			this.MinutosFin = "00";
			this.btnMinutosFin.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosFinTr.BackgroundColor = UIColor.Clear.FromHex(0x000000);
			this.HoraFin = this.HoraFinSeleccionada + ":" + this.MinutosFin;

			if (this.HoraFinSeleccionada != "" && this.MinutosInicio != "")
            {
				this.CalcularHorasReservadas(this.HoraInicio, this.HoraFin);
            }
		}

		partial void HoraInicioTreinta_Touch(UIButton sender)
		{
			this.MinutosInicio = "30";
			this.btnMinutosTreinta.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnMinutosCero.BackgroundColor = UIColor.Clear.FromHex(0x000000);
			this.HoraInicio = this.HoraInicioSeleccionada + ":" + this.MinutosInicio;
			if (this.HoraFinSeleccionada != "" && this.MinutosFin != "")
			{
				this.CalcularHorasReservadas(this.HoraInicio, this.HoraFin);
			}

		}

		private void CalcularHorasReservadas(string HInicio, string HFin)
        {
			if(HInicio != "" && HFin != "")
			{
				var intHoraInicio = float.Parse(HInicio.Split(':')[0]);
                var intHoraFin = float.Parse(HFin.Split(':')[0]);

                var minutosInicio = int.Parse(HInicio.Split(':')[1]);
                var minutosFin = int.Parse(HFin.Split(':')[1]);

                this.HorasReservadas = intHoraFin - intHoraInicio;
                if (minutosInicio == 30)
                {
                    intHoraInicio = intHoraInicio + 0.5f;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                }
                if (minutosFin == 30)
                {
                    intHoraFin = intHoraFin + 0.5f;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                }
			}
        }

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "SeleccionarSalaSegue")
			{
				var VistaSalas = (SeleccionarSalaTableView)segue.DestinationViewController;
				VistaSalas.SalasJuntas = this.SalasJuntas;
				VistaSalas.HoraInicio = this.HoraInicio;
				VistaSalas.HoraFin = this.HoraFin;
				VistaSalas.FechaSeleccionada = this.FechaSeleccionada;
				VistaSalas.HorasReservadas = this.HorasReservadas;

			}
			else if (segue.Identifier == "HoraInicioReservacion")
			{
				this.segueSegueHoraInicio = segue;
				this.ListadoHoraFin(this.HoraActual);
				var VistaHoraInicio = (HoraInicioCollectionView)segue.DestinationViewController;
				VistaHoraInicio.Horas = this.HorasFin;
				VistaHoraInicio.HoraInicioDelegate = this;
				VistaHoraInicio.ViewDidLoad();

			}
			else if (segue.Identifier == "HoraFinReservacion")
			{
				this.segueSegueHoraFin = segue;
				this.ListadoHoraInicio(this.HoraActual);
				var VistaHoraFin = (HoraFinCollectionView)segue.DestinationViewController;
				VistaHoraFin.Horas = this.HorasInicio;
				VistaHoraFin.HoraFinDelegate = this;
				VistaHoraFin.ViewDidLoad();
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
			if (this.HoraInicioSeleccionada != "" && this.MinutosInicio != "")
			{
				this.CalcularHorasReservadas(this.HoraInicio, this.HoraFin);
			}
		}

		public void SeleccionarHoraFin(string HoraFinSeleccionada)
		{
			if (HoraFinSeleccionada.Length == 1)
            {
				HoraFinSeleccionada = "0" + HoraFinSeleccionada;
            }
			this.HoraFinSeleccionada = HoraFinSeleccionada;
			this.HoraFin = this.HoraFinSeleccionada + ":" + this.MinutosFin;
			if (this.HoraFinSeleccionada != "" && this.MinutosFin != "")
			{
				this.CalcularHorasReservadas(this.HoraInicio, this.HoraFin);
			}

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