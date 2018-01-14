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

    public interface ReservacionConfirmada
    {
        void ReservacionConfirmada();
    }

    public partial class ConfirmarSalaJuntasController : UIViewController
    {

        public List<SalaJuntasReservacionModel> Reservaciones = new List<SalaJuntasReservacionModel>();


        public ReservacionConfirmada ReservacionConfirmadaDelegate;

        public ConfirmarSalaJuntasController (IntPtr handle) : base (handle)
        {
        }

        partial void btnConfirmar_Touch(UIButton sender)
        {
            var OperacionTerminada = false;
            foreach (SalaJuntasReservacionModel Reservacion in Reservaciones)
            {
                if(InternetConectionHelper.VerificarConexion())
                {
                    DateTime myDate = DateTime.ParseExact(Reservacion.Sala_Fecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    var asignacion = new SalasJuntasController().AsignarSalaJuntas("1", Reservacion.Sala_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), myDate, Reservacion.Sala_Hora_Inicio, Reservacion.Sala_Hora_Fin);
                    if (asignacion != -1)
                    {
                        OperacionTerminada = true;
                        this.GenerarEvento(Reservacion);
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
                this.ReservacionConfirmadaDelegate.ReservacionConfirmada();
                this.DismissViewController(true, null);
            }
        }

        partial void btnCancelar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
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
                VistaReservaciones.Reservaciones = this.Reservaciones;
            }
        }

    }
}