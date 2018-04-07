using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using EventKit;
using CoreLocation;

namespace WorklabsMx.iOS
{

    public interface EventosReservaciones
    {
        void ReservacionCancelada(SalaJuntasReservacionModel Reservaciones);
        void ReservacionConfirmada(SalaJuntasReservacionModel ReservacionesConcat);
    }


    public partial class ConfirmarSalaJuntasController : UIViewController
    {

        public SalaJuntasModel SalaActual;
        //public List<SalaJuntasReservacionModel> Reservaciones = new List<SalaJuntasReservacionModel>();
        //public List<SalaJuntasReservacionModel> ReservacionesConcat = new List<SalaJuntasReservacionModel>();

        public SalaJuntasReservacionModel Reservacion = new SalaJuntasReservacionModel();

        public EventosReservaciones EventosReservacionesDelegate;
        public string FechaReservacion;

        public ConfirmarSalaJuntasController (IntPtr handle) : base (handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //this.ReservacionesConcat = new List<SalaJuntasReservacionModel>();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            StyleHelper.StyleBlack(this.vwVsitaConfirmar.Layer);
            /*var indiceReservacionesConcat = 0;
            this.Reservaciones.Sort((p, q) => p.Sala_Hora_Inicio.CompareTo(q.Sala_Hora_Inicio));
            SalaJuntasReservacionModel Reservacion = new SalaJuntasReservacionModel();
            Reservacion = Reservaciones[indiceReservacionesConcat];
            ReservacionesConcat.Add(Reservacion);

            for (int indice = 0; indice < Reservaciones.Count - 1; indice++ )
            {
                if (Reservaciones[indice].Sala_Hora_Fin == Reservaciones[indice + 1].Sala_Hora_Inicio)
                {
                    ReservacionesConcat[indiceReservacionesConcat].Sala_Hora_Fin = Reservaciones[indice + 1].Sala_Hora_Fin;
                    ReservacionesConcat[indiceReservacionesConcat].Horas_Reservadas = ReservacionesConcat[indiceReservacionesConcat].Horas_Reservadas + 0.5f;
                }
                else
                {
                    ReservacionesConcat.Add(Reservaciones[indice + 1]);
                    indiceReservacionesConcat++;
                   
                }
            }*/

        }

        partial void btnConfirmar_Touch(UIButton sender)
        {
            var OperacionTerminada = false;

            if (InternetConectionHelper.VerificarConexion())
            {
                DateTime myDate = DateTime.ParseExact(Reservacion.Sala_Fecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (Reservacion.Sala_Hora_Inicio == "24:00")
                {
                    Reservacion.Sala_Hora_Inicio = "00:00";
                }

                if (Reservacion.Sala_Hora_Fin == "24:00")
                {
                    Reservacion.Sala_Hora_Fin = "00:00";
                }
                var asignacion = new SalasJuntasController().AsignarSalaJuntas("ALTA", Reservacion.Sala_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), myDate, Reservacion.Sala_Hora_Inicio, Reservacion.Sala_Hora_Fin);
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
                this.DismissViewController(true, () =>
                {

                 
                    this.GenerarEvento(Reservacion);


                    NSDateFormatter dateFormat = new NSDateFormatter();
                    dateFormat.DateFormat = "yyyy-MM-dd";
                    NSDate newFormatDate = dateFormat.Parse(FechaReservacion);

                    this.EnviarMail(MenuHelper.Usuario, SalaActual, newFormatDate, Reservacion);

                    this.EventosReservacionesDelegate.ReservacionConfirmada(this.Reservacion);

                });
            }
        }

        partial void btnCancelar_Touch(UIButton sender)
        {
            this.DismissViewController(true,() => 
            {
                this.EventosReservacionesDelegate.ReservacionCancelada(this.Reservacion);
            });
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

        private void GenerarEvento(SalaJuntasReservacionModel Reservacion)
        {
            RequestAccess(EKEntityType.Event, () =>
            {
                CLLocation location = new CLLocation();
                if (Reservacion.Sucursal_Id == "1")
                {
                    location = new CLLocation(20.6766, -103.3812);
                }
                else
                {
                    location = new CLLocation(20.6766, -103.3812);
                }
                var structuredLocation = new EKStructuredLocation();
                structuredLocation.Title = Reservacion.Sucursal_Domicilio;
                structuredLocation.GeoLocation = location;

                NSDateFormatter dateFormat = new NSDateFormatter();
                dateFormat.DateFormat = "dd/MM/yyyy";
                NSDate newFormatDate = dateFormat.Parse(Reservacion.Sala_Fecha);

                EKEvent newEvent = EKEvent.FromStore(AppHelper.Current.EventStore);

                DateTime myDate = DateTime.ParseExact(Reservacion.Sala_Fecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                var arrTime = Reservacion.Sala_Hora_Inicio.Split(':');
                var hora = (double.Parse(arrTime[0]) - 1);
                var minutos = double.Parse(arrTime[1]);
                myDate.AddHours(hora);
                myDate.AddMinutes(minutos);
                var HoraAntesReunion = myDate;
                newEvent.AddAlarm(EKAlarm.FromDate(DateTimeToNSDate(HoraAntesReunion.AddMinutes(30))));
                newEvent.AddAlarm(EKAlarm.FromDate(DateTimeToNSDate(HoraAntesReunion.AddMinutes(45))));
                if (myDate != null)
                {
                    hora = hora + 1;
                    myDate.AddHours(hora);
                    myDate.AddMinutes(minutos);
                    var HoraInicio = this.DateTimeToNSDate(myDate);
                    newEvent.StartDate = HoraInicio;
                    arrTime = Reservacion.Sala_Hora_Fin.Split(':');
                    hora = double.Parse(arrTime[0]);
                    minutos = double.Parse(arrTime[1]);
                    myDate.AddHours(hora);
                    myDate.AddMinutes(minutos);
                    newEvent.EndDate = this.DateTimeToNSDate(myDate);
                }
                newEvent.Title = "Reservación de sala de juntas en " + Reservacion.Sucursal_Descripcion;
                newEvent.Notes = "Se recomienda presentarse 5 minutos antes de su hora de reservación";
                newEvent.Calendar = AppHelper.Current.EventStore.DefaultCalendarForNewEvents;
                newEvent.Location = Reservacion.Sucursal_Domicilio;
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


        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if(segue.Identifier == "HorariosTable")
            {
                var VistaReservaciones = (ReservacionesTableView)segue.DestinationViewController;
                VistaReservaciones.Reservaciones = this.Reservacion;
            }
        }

    }
}