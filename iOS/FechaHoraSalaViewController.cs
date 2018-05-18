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
		private int HoraSeleccionada;
		private int HoraFinSeleccionada;
		private string MinutosInicio;
		private string MinutosFin;
		private string FechaSeleccionada;
		private List<UIButton> BotonesHoraInicio = new List<UIButton>();
		private List<UIButton> BotonesHoraFin = new List<UIButton>();
		private List<SalaJuntasModel> SalasJuntas = new List<SalaJuntasModel>();
		NSDateFormatter dateFormat = new NSDateFormatter();

		public FechaHoraSalaViewController (IntPtr handle) : base (handle)
        {
			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			dateFormat.DateFormat = "yyyy-MM-dd";
			this.FechaSeleccionada = dateFormat.ToString(dtpFecha.Date);
			this.CreateButtons();
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
			this.SalasJuntas = new SalasJuntasController().GetSalaJuntas(0, this.FechaSeleccionada, hora_inicio, hora_fin, capacidad);
			this.PerformSegue("SeleccionarSala", null);
		}
       
        private void CreateButtons()
		{
			nfloat XBotonHora = 0;
			CGRect FrameHorarios = new CGRect(this.vwHoraInicio.Frame.X, this.vwHoraInicio.Frame.Y, this.vwHoraInicio.Frame.Width * 23, this.vwHoraInicio.Frame.Height);
			this.vwHoraInicio.Frame = FrameHorarios;
			for (int IndiceBoton = 1; IndiceBoton < 24; IndiceBoton ++)
			{
				XBotonHora = XBotonHora + this.btnHoraInicio.Frame.Width;
				UIButton BotonHora = new UIButton();
				BotonHora.Frame = new CGRect(XBotonHora, this.btnHoraInicio.Frame.Y, this.btnHoraInicio.Frame.Width, this.btnHoraInicio.Frame.Height);
				BotonHora.SetTitle((IndiceBoton + 1).ToString(), UIControlState.Normal);
				BotonHora.TouchUpInside += (object sender, System.EventArgs e) => {
					this.ActionButtons(BotonHora);
                };
				this.BotonesHoraInicio.Add(BotonHora);
				this.vwHoraInicio.Add(BotonHora);
			}
			this.scvHoraInicio.ContentSize = this.vwHoraInicio.Frame.Size;


			XBotonHora = 0;
			FrameHorarios = new CGRect(this.vwHoraFin.Frame.X, this.vwHoraFin.Frame.Y, this.vwHoraFin.Frame.Width * 23, this.vwHoraFin.Frame.Height);
			this.vwHoraFin.Frame = FrameHorarios;
            for (int IndiceBoton = 1; IndiceBoton < 24; IndiceBoton++)
            {
                XBotonHora = XBotonHora + this.btnHoraFin.Frame.Width;
                UIButton BotonHora = new UIButton();
				BotonHora.Frame = new CGRect(XBotonHora, this.btnHoraFin.Frame.Y, this.btnHoraFin.Frame.Width, this.btnHoraFin.Frame.Height);
                BotonHora.SetTitle((IndiceBoton + 1).ToString(), UIControlState.Normal);
                BotonHora.TouchUpInside += (object sender, System.EventArgs e) => {
					this.ActionButtonsFin(BotonHora);
                };
				this.BotonesHoraFin.Add(BotonHora);
				this.vwHoraFin.Add(BotonHora);
            }
			this.scvHoraFin.ContentSize = this.vwHoraFin.Frame.Size;

		}

		private void ActionButtons(UIButton BotonHora)
		{
			foreach (UIButton Boton in BotonesHoraInicio)
            {
                Boton.BackgroundColor = UIColor.White;
                Boton.TitleLabel.TextColor = UIColor.Black;
            }
			this.HoraSeleccionada = int.Parse(BotonHora.TitleLabel.Text);
			BotonHora.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			BotonHora.TitleLabel.TextColor = UIColor.Clear.FromHex(0xFFFFFF);
		}

		private void ActionButtonsFin(UIButton BotonHora)
        {
			foreach(UIButton Boton in BotonesHoraFin)
			{
				Boton.BackgroundColor = UIColor.White;
				Boton.TitleLabel.TextColor = UIColor.Black;
			}
			this.HoraFinSeleccionada = int.Parse(BotonHora.TitleLabel.Text);
            BotonHora.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
            BotonHora.TitleLabel.TextColor = UIColor.Clear.FromHex(0xFFFFFF);
        }

		partial void dtpFecha_Cahnged(UIDatePicker sender)
		{
			this.FechaSeleccionada = dateFormat.ToString(sender.Date);

		}

		partial void btnHoraInicio_Touch(UIButton sender)
		{
			this.HoraSeleccionada = int.Parse(sender.TitleLabel.Text);
			sender.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			sender.TitleLabel.TextColor = UIColor.Clear.FromHex(0xFFFFFF);
		}

		partial void btnHoraFin_Touch(UIButton sender)
		{
			this.HoraFinSeleccionada = int.Parse(sender.TitleLabel.Text);
            sender.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
            sender.TitleLabel.TextColor = UIColor.Clear.FromHex(0xFFFFFF);
		}

		partial void HoraInicioCero_Touch(UIButton sender)
		{
			this.MinutosInicio = "00";
		}

		partial void HoraFinTreinta_Touch(UIButton sender)
		{
			this.MinutosFin = "30";
		}

		partial void HoraFinCero_Touch(UIButton sender)
		{
			this.MinutosFin = "00";
		}

		partial void HoraInicioTreinta_Touch(UIButton sender)
		{
			this.MinutosInicio = "30";
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if(segue.Identifier == "SeleccionarSala")
			{
				var VistaSalas = (SeleccionarSalaTableView)segue.DestinationViewController;
				VistaSalas.SalasJuntas = this.SalasJuntas;
			}
		}
	}
}