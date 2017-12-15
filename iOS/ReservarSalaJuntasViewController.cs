using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class ReservarSalaJuntasViewController : UIViewController
    {

        public string SucursalId;
        NSDateFormatter dateFormat = new NSDateFormatter();
        //UIScrollView ScrollVista;

        public ReservarSalaJuntasViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //ScrollVista = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
            //ScrollVista.AddSubview(this.vwVista);
            //this.View.AddSubview(ScrollVista);
            StyleHelper.Style(this.vwBotonFecha.Layer); 
            StyleHelper.Style(this.vwInfoReservacion.Layer);
            dateFormat.DateFormat = "dd/MM/yyyy";
            this.btnSeleccionFecha.SetTitle(dateFormat.ToString(NSDate.Now), UIControlState.Normal);
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
        public void FechaReservaSeleccionada(String  FechaReservacion)
        {
            this.btnSeleccionFecha.SetTitle(FechaReservacion, UIControlState.Normal);
        }
    }
}