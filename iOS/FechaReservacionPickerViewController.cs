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
        NSDateFormatter dateFormat = new NSDateFormatter();
        public FechaReservaSeleccionada FechaSeleccionadaDelegate;
        string FechaReservacion;

        public FechaReservacionPickerViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.dtpFechaReservacion.MaximumDate = NSDate.Now;
            dateFormat.DateFormat = "dd/MM/yyyy";
            this.FechaReservacion = dateFormat.ToString(this.dtpFechaReservacion.Date);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            //var color = new UIColor(0, 0.0f);
            //this.View.BackgroundColor = color;
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