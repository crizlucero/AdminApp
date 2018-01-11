using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.Models;
using EventKit;
using EventKitUI;
using System.Linq;
using MonoTouch.Dialog;


namespace WorklabsMx.iOS
{
    public partial class ConfirmarSalaJuntasController : UIViewController
    {

        public List<SalaJuntasReservacionModel> Reservaciones = new List<SalaJuntasReservacionModel>();

        public ConfirmarSalaJuntasController (IntPtr handle) : base (handle)
        {
        }

        partial void btnConfirmar_Touch(UIButton sender)
        {
            this.GenerarEvento();
        }

        partial void btnCancelar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        private void GenerarEvento()
        {
            EKEvent newEvent = EKEvent.FromStore(AppHelper.Current.EventStore);
            // set the alarm for 10 minutes from now
            newEvent.AddAlarm(EKAlarm.FromDate((NSDate)DateTime.Now.AddMinutes(10)));
            // make the event start 20 minutes from now and last 30 minutes
            newEvent.StartDate = (NSDate)DateTime.Now.AddMinutes(20);
            newEvent.EndDate = (NSDate)DateTime.Now.AddMinutes(50);
            newEvent.Title = "Get outside and do some exercise!";
            newEvent.Notes = "This is your motivational event to go and do 30 minutes of exercise. Super important. Do this.";
        }
    }
}