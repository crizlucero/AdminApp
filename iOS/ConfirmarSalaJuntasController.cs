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
        void ReservacionCancelada(List<SalaJuntasReservacionModel> Reservaciones);
        void ReservacionConfirmada(List<SalaJuntasReservacionModel> ReservacionesConcat);
    }


    public partial class ConfirmarSalaJuntasController : UIViewController
    {

        public List<SalaJuntasReservacionModel> Reservaciones = new List<SalaJuntasReservacionModel>();
        public List<SalaJuntasReservacionModel> ReservacionesConcat = new List<SalaJuntasReservacionModel>();

        public EventosReservaciones EventosReservacionesDelegate;

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
            var indiceReservacionesConcat = 0;
            this.Reservaciones.Sort((p, q) => -1 * int.Parse(p.Sala_Hora_Inicio).CompareTo(int.Parse(q.Sala_Hora_Inicio)));
            SalaJuntasReservacionModel Reservacion = new SalaJuntasReservacionModel();
            Reservacion = Reservaciones[indiceReservacionesConcat];
            ReservacionesConcat.Add(Reservacion);

            for (int indice = 0; indice < Reservaciones.Count - 1; indice++ )
            {
                if (int.Parse(Reservaciones[indice].Sala_Hora_Inicio) == int.Parse(Reservaciones[indice + 1].Sala_Hora_Fin))
                {
                    ReservacionesConcat[indiceReservacionesConcat].Sala_Hora_Inicio = Reservaciones[indice + 1].Sala_Hora_Inicio;
                    ReservacionesConcat[indiceReservacionesConcat].Horas_Reservadas = ReservacionesConcat[indiceReservacionesConcat].Horas_Reservadas + 1;
                }
                else
                {
                    ReservacionesConcat.Add(Reservaciones[indice + 1]);
                    indiceReservacionesConcat++;
                   
                }
            }

        }

        partial void btnConfirmar_Touch(UIButton sender)
        {
            var OperacionTerminada = false;
           
            foreach (SalaJuntasReservacionModel Reservacion in Reservaciones)
            {
                Reservacion.Sala_Hora_Inicio = (int.Parse(Reservacion.Sala_Hora_Fin) - 1).ToString();

                if (Reservacion.Sala_Hora_Inicio.Length == 1)
                {
                    Reservacion.Sala_Hora_Inicio = "0" + Reservacion.Sala_Hora_Inicio;
                }

                if(InternetConectionHelper.VerificarConexion())
                {
                    DateTime myDate = DateTime.ParseExact(Reservacion.Sala_Fecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    if (Reservacion.Sala_Hora_Inicio == "24")
                    {
                        Reservacion.Sala_Hora_Inicio = "00";
                    }

                    if (Reservacion.Sala_Hora_Fin == "24")
                    {
                        Reservacion.Sala_Hora_Fin = "00";
                    }
                    var asignacion = new SalasJuntasController().AsignarSalaJuntas("ALTA", Reservacion.Sala_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), myDate, Reservacion.Sala_Hora_Inicio + ":00", Reservacion.Sala_Hora_Fin + ":00");
                    if (asignacion != -1)
                    {
                        OperacionTerminada = true;

                    }
                    else
                    {
                        OperacionTerminada = false;
                        break;
                    }
                }
               
            }

            if (OperacionTerminada)
            {
                this.DismissViewController(true, () =>
                {

                    foreach (SalaJuntasReservacionModel ReservacionConcat in ReservacionesConcat)
                    {
                        string HoraInicio = (int.Parse(ReservacionConcat.Sala_Hora_Inicio) - (ReservacionConcat.Horas_Reservadas - 1)).ToString();
                        if (HoraInicio.Length == 1)
                        {
                            ReservacionConcat.Sala_Hora_Inicio = "0" + HoraInicio;
                        }
                        else
                        {
                            ReservacionConcat.Sala_Hora_Inicio = HoraInicio;
                        }

                        this.GenerarEvento(ReservacionConcat);
                    }

                    this.EventosReservacionesDelegate.ReservacionConfirmada(this.ReservacionesConcat);

                });
            }
        }

        partial void btnCancelar_Touch(UIButton sender)
        {
            this.DismissViewController(true,() => 
            {
                this.EventosReservacionesDelegate.ReservacionCancelada(this.Reservaciones);
            });
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
                var structuredLocation = new EKStructuredLocation();
                structuredLocation.Title = Reservacion.Sucursal_Domicilio;
                structuredLocation.GeoLocation = location;

                NSDateFormatter dateFormat = new NSDateFormatter();
                dateFormat.DateFormat = "dd/MM/yyyy";
                NSDate newFormatDate = dateFormat.Parse(Reservacion.Sala_Fecha);

                EKEvent newEvent = EKEvent.FromStore(AppHelper.Current.EventStore);

                DateTime myDate = DateTime.ParseExact(Reservacion.Sala_Fecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                var HoraAntesReunion = myDate.AddHours(int.Parse(Reservacion.Sala_Hora_Inicio) - 1);
                newEvent.AddAlarm(EKAlarm.FromDate(DateTimeToNSDate(HoraAntesReunion.AddMinutes(30))));
                newEvent.AddAlarm(EKAlarm.FromDate(DateTimeToNSDate(HoraAntesReunion.AddMinutes(45))));
                if (myDate != null)
                {
                    newEvent.StartDate = this.DateTimeToNSDate(myDate.AddHours(int.Parse(Reservacion.Sala_Hora_Inicio)));
                    newEvent.EndDate = this.DateTimeToNSDate(myDate.AddHours(int.Parse(Reservacion.Sala_Hora_Fin)));
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
                VistaReservaciones.Reservaciones = this.ReservacionesConcat;
            }
        }

    }
}