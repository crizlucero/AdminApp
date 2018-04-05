using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    
    public interface EventosHoraFinSeleccionada
    {
        void HoraFinSeleccionada(string HoraSeleccionada);
    }

    public partial class HoraFinView : UIViewController
    {

        public EventosHoraFinSeleccionada HoraSeleccionadadaDelegate;

        public HoraFinView (IntPtr handle) : base (handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
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
    }
}