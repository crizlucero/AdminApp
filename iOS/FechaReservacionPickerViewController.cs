using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

    public interface FechaReservaSeleccionada
    {
        void FechaReservaSeleccionada(String FechaNacimiento);
    }

    public partial class FechaReservacionPickerViewController : UIViewController
    {
        public bool FromRegister = false;

        NSDateFormatter dateFormat = new NSDateFormatter();
        public FechaReservaSeleccionada FechaSeleccionadaDelegate;
        string FechaReservacion;

        public FechaReservacionPickerViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.dtpFechaReservacion.MinimumDate = (NSDate)DateTime.Now;
            if (FromRegister)
            {
                dateFormat.DateFormat = "E, d MMM yyyy HH:mm";
            }
            else
            {
                dateFormat.DateFormat = "dd/MM/yyyy";

            }
            this.FechaReservacion = dateFormat.ToString(this.dtpFechaReservacion.Date);
        }

        partial void btnCancelar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnSeleccionar_Touch(UIButton sender)
        {
            this.FechaSeleccionadaDelegate.FechaReservaSeleccionada(this.FechaReservacion);
            this.DismissViewController(true, null);
        }

        partial void dtpFechaReservacion_ValueChanged(UIDatePicker sender)
        {
            this.FechaReservacion = dateFormat.ToString(sender.Date);
        }
    }
}