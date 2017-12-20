using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class ReservarSalaJuntasViewTableController : UITableViewController
    {

        public string SucursalId;
        NSDateFormatter dateFormat = new NSDateFormatter();

        nint NumberOfMR = 5;

        public ReservarSalaJuntasViewTableController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            nfloat WidthView = 0;
            nfloat XImageView = 0;

            for (int indice = 0; indice < NumberOfMR; indice ++)
            {
                WidthView = WidthView + this.vwSalasJuntas.Frame.Width;
            }
            this.pcSucursales.Pages = NumberOfMR;
            CGRect newFrame = new CGRect(this.vwSalasJuntas.Frame.X, this.vwSalasJuntas.Frame.Y, WidthView, this.vwSalasJuntas.Frame.Height);

            this.vwSalasJuntas.Frame = newFrame;

            for (int indice = 1; indice < NumberOfMR; indice++)
            {
                XImageView = XImageView + this.imgSalasJuntas.Frame.Width;
                UIImageView ImagenSalaJuntas = new UIImageView();
                ImagenSalaJuntas.Frame = new CGRect(XImageView, this.imgSalasJuntas.Frame.Y, this.imgSalasJuntas.Frame.Width, this.imgSalasJuntas.Frame.Height);
                ImagenSalaJuntas.Image = UIImage.FromBundle("SalaJuntas");
                this.vwSalasJuntas.Add(ImagenSalaJuntas);
            }

            this.scvSalasJuntas.ContentSize = vwSalasJuntas.Frame.Size;
            this.scvSalasJuntas.Scrolled += (sender, e) =>
            {
                this.pcSucursales.CurrentPage = (nint)(scvSalasJuntas.ContentOffset.X / scvSalasJuntas.Frame.Width);
            };

            this.scvScrollHorarios.ContentSize = vwHorarios.Frame.Size;

            StyleHelper.Style(this.vwBotonFecha.Layer);
            StyleHelper.Style(this.vwInfoReservacion.Layer);
            dateFormat.DateFormat = "dd/MM/yyyy";
            this.btnSeleccionFecha.SetTitle(dateFormat.ToString(NSDate.Now), UIControlState.Normal);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
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