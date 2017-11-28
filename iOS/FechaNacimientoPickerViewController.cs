using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

    public interface FechaNacimientoSeleccionada
    {
        void FechaSeleccionada(DateTime FechaNacimiento);
    }

    public partial class FechaNacimientoPickerViewController : UIViewController
    {
        public FechaNacimientoPickerViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            var color = new UIColor(0, 0.0f);
            this.View.BackgroundColor = color;
        }

        partial void btnSeleccionar_TouchUpInside(UIButton sender)
        {
            
        }

        partial void btnCancelar_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void dtpFechaNacimiento_ValueChanged(UIDatePicker sender)
        {
            
        }
    }
}