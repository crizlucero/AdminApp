using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class ReservarSalaJuntasViewTableController : UITableViewController
    {

        public string SucursalId;
        NSDateFormatter dateFormat = new NSDateFormatter();

        public ReservarSalaJuntasViewTableController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            StyleHelper.Style(this.vwBotonFecha.Layer);
            StyleHelper.Style(this.vwInfoReservacion.Layer);
            dateFormat.DateFormat = "dd/MM/yyyy";
            this.btnSeleccionFecha.SetTitle(dateFormat.ToString(NSDate.Now), UIControlState.Normal);
        }

        partial void btnSeleccionarFecha_Touch(UIButton sender)
        {
            this.PerformSegue("SelectDate", null);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SelectDate")
            {
                var GenderView = (FechaReservacionPickerViewController)segue.DestinationViewController;
                GenderView.FechaSeleccionadaDelegate = this;
            }
        }

    }


    partial class ReservarSalaJuntasViewTableController : FechaReservaSeleccionada
    {
        public void FechaReservaSeleccionada(String FechaReservacion)
        {
            this.btnSeleccionFecha.SetTitle(FechaReservacion, UIControlState.Normal);
        }
    }
}