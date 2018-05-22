using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using EventKit;
using CoreLocation;
using System.Globalization;
using System.Collections.Generic;


namespace WorklabsMx.iOS
{
    public partial class DetalleReservacionViewController : UITableViewController
    {
    
		public SalaJuntasModel SalaJuntasSeleccionada;
		public SalaJuntasReservacionModel Reservacion = new SalaJuntasReservacionModel();

		public string HoraInicio;
        public string HoraFin;
        public string FechaSeleccionada;
        public float HorasReservadas;
        public float CreditosAcumulados;

		private List<UIImage> ImagenesSala = new List<UIImage>();

        public DetalleReservacionViewController (IntPtr handle) : base (handle)
        {
        }
        
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.Reservacion = new SalaJuntasReservacionModel(SalaJuntasSeleccionada.Sala_Id, HoraInicio, HoraFin, this.FechaSeleccionada, "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaJuntasSeleccionada.Sala_Descripcion, this.SalaJuntasSeleccionada.Sala_Capacidad, this.SalaJuntasSeleccionada.Sala_Nivel, this.SalaJuntasSeleccionada.Sucursal_Descripcion, this.SalaJuntasSeleccionada.Sucursal_Id, this.SalaJuntasSeleccionada.Sala_Id, this.HorasReservadas, this.CreditosAcumulados);
			string newFormatDate = DateTime.ParseExact(this.FechaSeleccionada, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("d 'de' MMMM, 'del' yyyy");
			this.lblFecha.Text = newFormatDate;
			this.lblHora.Text = this.HoraInicio + " - " + this.HoraFin + " / " + this.HorasReservadas + "Hrs.";
			this.lblCreditosUsar.Text = this.CreditosAcumulados.ToString();
			this.lblCreditosDisponibles.Text = "";
			this.lblNombre.Text = this.SalaJuntasSeleccionada.Sala_Descripcion;
			this.lblNivel.Text = "NIVEL " + this.SalaJuntasSeleccionada.Sala_Nivel;
			this.lblCantidadPersonas.Text = "Sala para " + this.SalaJuntasSeleccionada.Sala_Capacidad + " personas";
			this.lblDescripcion.Text = this.SalaJuntasSeleccionada.Sala_Descripcion;
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if(segue.Identifier == "Confirmacion")
			{
				var VistaConfirmacion = (ConfirmacionReservaSalaViewController)segue.DestinationViewController.ChildViewControllers[0];
				VistaConfirmacion.Fecha = this.lblFecha.Text;
				VistaConfirmacion.Horas = this.lblHora.Text;
				VistaConfirmacion.SalaNombre = this.lblNombre.Text;
				VistaConfirmacion.CantidadPersonas = this.lblCantidadPersonas.Text;
				VistaConfirmacion.Nivel = this.lblNivel.Text;

			}
			else if (segue.Identifier == "ImagenesSala")
			{
				var VistaColeccionImagenes = (ImagenesSalaCollectionView)segue.DestinationViewController;
				VistaColeccionImagenes.ImagenesSala = this.ImagenesSala;
			}
		}

		partial void btnRetroceder_Touch(UIButton sender)
		{
			var controller = Storyboard.InstantiateViewController("SeleccionarSalaTableView");
            this.NavigationController.PushViewController(controller, true);
		}

		partial void btnAvanzar_Touch(UIButton sender)
		{
			this.AgendarSala();
		}

        private void AgendarSala()
		{
			var OperacionTerminada = false;

            if (InternetConectionHelper.VerificarConexion())
            {
                DateTime myDate = DateTime.ParseExact(Reservacion.Sala_Fecha, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                if (Reservacion.Sala_Hora_Inicio == "24:00")
                {
                    Reservacion.Sala_Hora_Inicio = "00:00";
                }

                if (Reservacion.Sala_Hora_Fin == "24:00")
                {
                    Reservacion.Sala_Hora_Fin = "00:00";
                }
                var asignacion = new SalasJuntasController().AsignarSalaJuntas("ALTA", Reservacion.Sala_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), myDate, Reservacion.Sala_Hora_Inicio, Reservacion.Sala_Hora_Fin, Reservacion.Creditos_Usados.ToString());
                if (asignacion != -1)
                {
                    OperacionTerminada = true;
                }
                else
                {
                    OperacionTerminada = false;
                }

            }

			if (OperacionTerminada)
			{
				this.GenerarEvento(Reservacion);
				NSDateFormatter dateFormat = new NSDateFormatter();
				dateFormat.DateFormat = "yyyy-MM-dd";
				NSDate newFormatDate = dateFormat.Parse(this.FechaSeleccionada);
				this.EnviarMail(MenuHelper.Usuario, SalaJuntasSeleccionada, newFormatDate, Reservacion);
				this.PerformSegue("Confirmacion", null);
			}
		}

		private void EnviarMail(UsuarioModel usuario, SalaJuntasModel Sala, NSDate Fecha, SalaJuntasReservacionModel Reservas)
        {
            string Horarios = "";

            Horarios = Horarios + Reservas.Sala_Hora_Inicio + " - " + Reservas.Sala_Hora_Fin + " ";
            
            NSDateFormatter dateFormat = new NSDateFormatter();
            dateFormat.DateFormat = "dd";
            var DiaSeleccionado = dateFormat.ToString(Fecha);

            dateFormat.DateFormat = "dd/MM/yyyy";
            var fecha = dateFormat.ToString(Fecha);

            string correoInvitacion = System.IO.File.ReadAllText("HTML/SalaJuntasReserva.html");
            new Emails().SendMail(usuario.Usuario_Correo_Electronico, usuario.Usuario_Nombre + " " + usuario.Usuario_Apellidos,
                                       correoInvitacion.Replace("{{NOMBRE}}", usuario.Usuario_Nombre + " " + usuario.Usuario_Apellidos)
                                  .Replace("{{NOMBRESALA}}", Sala.Sala_Descripcion)
                                  .Replace("{{CAPACIDADSALA}}", Sala.Sala_Capacidad)
                                  .Replace("{{DIALETRA}}", fecha)
                                  .Replace("{{DIANUMERO}}", DiaSeleccionado)
                                  .Replace("{{HORARIO}}", Horarios),
                                  "Worklabs - Confirmación de sala de junta");
        }

        private void GenerarEvento(SalaJuntasReservacionModel Reservaciones)
        {
            RequestAccess(EKEntityType.Event, () =>
            {
                CLLocation location = new CLLocation();
                if (Reservaciones.Sucursal_Id == "1")
                {
                    location = new CLLocation(20.6766, -103.3812);
                }
                else
                {
                    location = new CLLocation(20.6766, -103.3812);
                }
                var structuredLocation = new EKStructuredLocation();
                structuredLocation.Title = Reservaciones.Sucursal_Domicilio;
                structuredLocation.GeoLocation = location;

                NSDateFormatter dateFormat = new NSDateFormatter();
                dateFormat.DateFormat = "dd/MM/yyyy";
                NSDate newFormatDate = dateFormat.Parse(Reservaciones.Sala_Fecha);

                EKEvent newEvent = EKEvent.FromStore(AppHelper.Current.EventStore);

                DateTime myDate = DateTime.ParseExact(Reservaciones.Sala_Fecha, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                var arrTime = Reservaciones.Sala_Hora_Inicio.Split(':');
                var hora = (double.Parse(arrTime[0]) - 1);
                var minutos = double.Parse(arrTime[1]);
                var newDate = myDate.AddHours(hora);
                var newDate2 = newDate.AddMinutes(minutos);
                var HoraAntesReunion = newDate2;
                newEvent.AddAlarm(EKAlarm.FromDate(DateTimeToNSDate(HoraAntesReunion.AddMinutes(30))));
                newEvent.AddAlarm(EKAlarm.FromDate(DateTimeToNSDate(HoraAntesReunion.AddMinutes(45))));
                if (newDate2 != null)
                {
                    hora = hora + 1;
                    var newDate3 = myDate.AddHours(hora);
                    var newDate4 = newDate3.AddMinutes(minutos);

                    var HoraInicio = this.DateTimeToNSDate(newDate4);
                    newEvent.StartDate = HoraInicio;
                    arrTime = Reservaciones.Sala_Hora_Fin.Split(':');
                    hora = double.Parse(arrTime[0]);
                    minutos = double.Parse(arrTime[1]);
                    var newDate5 = myDate.AddHours(hora);
                    var newDate6 = newDate5.AddMinutes(minutos);
                    newEvent.EndDate = this.DateTimeToNSDate(newDate6);
                }
                newEvent.Title = "Reservación de sala de juntas en " + Reservaciones.Sucursal_Descripcion + ", en el piso " + Reservaciones.Sala_Nivel + ", en la sala " + Reservaciones.Sala_Descripcion;
                newEvent.Notes = "Se recomienda presentarse 5 minutos antes de su hora de reservación";
                newEvent.Calendar = AppHelper.Current.EventStore.DefaultCalendarForNewEvents;
                newEvent.Location = Reservaciones.Sucursal_Domicilio;
                newEvent.StructuredLocation = structuredLocation;
                NSError e;
                AppHelper.Current.EventStore.SaveEvent(newEvent, EKSpan.ThisEvent, out e);
            });

        }

        protected void RequestAccess(EKEntityType type, Action completion)
        {
            AppHelper.Current.EventStore.RequestAccess(type,
                (bool granted, NSError e) => {
                    InvokeOnMainThread(() =>
                    {
                        if (granted)
                        {
                            completion.Invoke();
                        }
                        else
                        {
                            new MessageDialog().SendToast("Acceso denegado, no tienes acceso a el calendario");
                        }

                    });
                });
        }


        public NSDate DateTimeToNSDate(DateTime date)
        {
            if (date.Kind == DateTimeKind.Unspecified)
                date = DateTime.SpecifyKind(date, DateTimeKind.Local);
            return (NSDate)date;
        }


	}
}