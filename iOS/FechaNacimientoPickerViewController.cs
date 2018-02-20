using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

    public interface FechaNacimientoSeleccionada
    {
        void FechaSeleccionada(String FechaNacimiento);
    }

    public partial class FechaNacimientoPickerViewController : UIViewController
    {
        NSDateFormatter dateFormat = new NSDateFormatter();
        public FechaNacimientoSeleccionada FechaSeleccionadaDelegate;
        string FechaNacimiento;

        public FechaNacimientoPickerViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.dtpFechaNacimiento.MaximumDate = NSDate.Now;
            dateFormat.DateFormat = "yyyy-MM-dd"; 
            this.FechaNacimiento = dateFormat.ToString(this.dtpFechaNacimiento.Date);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            var color = new UIColor(0, 0.0f);
            this.View.BackgroundColor = color;
        }

        partial void btnSeleccionar_TouchUpInside(UIButton sender)
        {
            this.FechaSeleccionadaDelegate.FechaSeleccionada(this.FechaNacimiento);
            this.DismissViewController(true, null);
        }

        partial void btnCancelar_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void dtpFechaNacimiento_ValueChanged(UIDatePicker sender)
        {
            this.FechaNacimiento = dateFormat.ToString(sender.Date);
        }
    }
}