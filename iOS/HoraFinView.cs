using Foundation;
using System;
using UIKit;
using System.Globalization;

namespace WorklabsMx.iOS
{
    public interface EventosHoraFinSeleccionada
    {
        void HoraFinSeleccionada(string HoraSeleccionada, string HoraFin);
    }

    public partial class HoraFinView : UIViewController
    {
        public EventosHoraFinSeleccionada HoraSeleccionadadaDelegate;
        public string MinDate;
        public DateTime MiniDate = new DateTime();

        public HoraFinView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            dtpHoraFin.Locale = new NSLocale("en_US");
            var currentTime = MiniDate.AddMinutes(30);
            if (currentTime.Kind == DateTimeKind.Unspecified)
            {
                currentTime = DateTime.SpecifyKind(currentTime, DateTimeKind.Local);
            }
            dtpHoraFin.MinimumDate = (NSDate)currentTime;//CambiarFormato();
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
            var hora = this.CambiarFormatoString();
            var HoraFin = this.Formato24();
            HoraSeleccionadadaDelegate.HoraFinSeleccionada(hora, HoraFin);
            this.DismissViewController(true, null);
        }

        partial void dtpHoraFin_Changed(UIDatePicker sender)
        {
            
        }

        private NSDate CambiarFormato()
        {
            NSDateFormatter dateFormat = new NSDateFormatter();
            dateFormat.DateFormat = "HH:mm";
            return dateFormat.Parse(MinDate);
        }

        private string CambiarFormatoString()
        {
            NSDateFormatter dateFormat = new NSDateFormatter();
            dateFormat.DateFormat = "hh:mm a";
            return dateFormat.ToString(dtpHoraFin.Date);
        }

        private string Formato24()
        {
            DateTime dt = DateTime.SpecifyKind((DateTime)dtpHoraFin.Date, DateTimeKind.Utc).ToLocalTime();
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