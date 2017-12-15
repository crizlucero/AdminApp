using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class ReservarSalaJuntasViewController : UIViewController
    {

        public string SucursalId;

        public ReservarSalaJuntasViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            StyleHelper.Style(this.vwBotonFecha.Layer); 
            StyleHelper.Style(this.vwInfoReservacion.Layer);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        partial void btnSiguiente_Touch(UIButton sender)
        {
            
        }

        partial void btnSalanAnterior_Touch(UIButton sender)
        {
            
        }

        partial void btnAgendar_Touch(UIButton sender)
        {
            
        }

        partial void btnSeleccionFecha_Touch(UIButton sender)
        {
           
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


    partial class ReservarSalaJuntasViewController : FechaReservaSeleccionada
    {
        public void FechaReservaSeleccionada(String FechaNacimiento)
        {
            //this.lblFechaNacimiento.Text = FechaNacimiento;
        }
    }
}