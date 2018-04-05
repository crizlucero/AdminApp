using Foundation;
using System;
using UIKit;
using System.Globalization;

namespace WorklabsMx.iOS
{
    public interface EventosHoraFinSeleccionada
    {
        void HoraFinSeleccionada(string HoraSeleccionada);
    }

    public partial class HoraFinView : UIViewController
    {
        public EventosHoraFinSeleccionada HoraSeleccionadadaDelegate;
        public string MinDate;
        DateTime MiniDate;

        public HoraFinView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //var MiniDate = DateTime.ParseExact(MinDate, "hh:mm a", CultureInfo.InvariantCulture);
            dtpHoraFin.MinimumDate = this.CambiarFormato();
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
            var hora = dtpHoraFin.Date.ToString();
            HoraSeleccionadadaDelegate.HoraFinSeleccionada(hora);
            this.DismissViewController(true, null);
        }

        partial void dtpHoraFin_Changed(UIDatePicker sender)
        {
        }

        private string CambiarFormato()
        {
            NSDateFormatter dateFormat = new NSDateFormatter();
            dateFormat.DateFormat = "hh:mm a";
            return dateFormat.ToString((NSDate)MiniDate.AddMinutes(30));
        }
    }
}