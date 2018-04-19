using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using WorklabsMx.Enum;

namespace WorklabsMx.iOS
{


    public interface EventosHoraInicioSeleccionada
    {
        void HoraInicioSeleccionada(string HoraSeleccionada, string HoraInicio);
    }

    public partial class HoraInicioView : UIViewController
    {
        public EventosHoraInicioSeleccionada HoraSeleccionadadaDelegate;

        public HoraInicioView (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            try
            {
                dtpHoraInicio.Locale = new NSLocale("en_US");
                dtpHoraInicio.MinimumDate = (NSDate)DateTime.Now.AddMinutes(30);
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "HoraInicioView");
            }
        }

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		partial void btnCancelar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnSeleccionar_Touch(UIButton sender)
        {
            var hora = this.CambiarFormato();
            var HoraInicio = this.Formato24();
            HoraSeleccionadadaDelegate.HoraInicioSeleccionada(hora, HoraInicio);
            this.DismissViewController(true, null);
        }

        partial void dtpHoraInicio_Changed(UIDatePicker sender)
        {
            
        }

        private string CambiarFormato()
        {
            NSDateFormatter dateFormat = new NSDateFormatter();
            dateFormat.DateFormat = "hh:mm a";

            var lstHora = dateFormat.ToString(dtpHoraInicio.Date).Split(':');
            var hora = int.Parse(lstHora[0]);
            var min = int.Parse(lstHora[1].Remove(2, 3));

            string strMin = min.ToString();

            string newHora = hora.ToString();
            if (hora.ToString().Length == 1)
            {
                newHora = newHora.Insert(0, "0");
            }
            if ((min >= 0 && min < 30))
            {
                strMin = "00";
            }
            if ((min >= 30 && min <= 59))
            {
                strMin = "30";
            }
            var Meridiano = dateFormat.ToString(dtpHoraInicio.Date).Substring(6);
            var horario = newHora + ":" + strMin + " " + Meridiano;
            return horario;
        }


        private string Formato24()
        {
            DateTime dt = DateTime.SpecifyKind((DateTime)dtpHoraInicio.Date, DateTimeKind.Utc).ToLocalTime();
            var lstHora = dt.ToString("HH:mm").Split(':');
            var hora = int.Parse(lstHora[0]);
            var min = int.Parse(lstHora[1]);
            string newHora = hora.ToString();
            if (hora.ToString().Length == 1)
            {
                newHora = newHora.Insert(0, "0");
            }
            string strMin = min.ToString();
            if ((min >= 0 && min < 30))
            {
                strMin = "00";
            }
            if ((min >= 30 && min <= 59))
            {
                strMin = "30";
            }
            var horario = newHora + ":" + strMin;
            return horario;
        }
    }
}