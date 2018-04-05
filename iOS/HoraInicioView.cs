using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{


    public interface EventosHoraInicioSeleccionada
    {
        void HoraInicioSeleccionada(string HoraSeleccionada);
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

            dtpHoraInicio.MinimumDate = (NSDate)DateTime.Now.AddMinutes(30);
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
            HoraSeleccionadadaDelegate.HoraInicioSeleccionada(hora);
            this.DismissViewController(true, null);
        }

        partial void dtpHoraInicio_Changed(UIDatePicker sender)
        {
            
        }

        private string CambiarFormato()
        {
            NSDateFormatter dateFormat = new NSDateFormatter();
            dateFormat.DateFormat = "hh:mm a";
            return dateFormat.ToString(dtpHoraInicio.Date);
        }
    }
}