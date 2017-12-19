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


        nfloat h = 50.0f;
        nfloat w = 50.0f;
        nfloat padding = 10.0f;
        nint n = 5;

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

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            /*this.scvScrollSalasJuntas.CanCancelContentTouches = false;
            this.scvScrollSalasJuntas.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
            this.scvScrollSalasJuntas.ClipsToBounds = false;
            this.scvScrollSalasJuntas.ScrollEnabled = true;
            this.scvScrollSalasJuntas.PagingEnabled = true;

            //this.scvScrollSalasJuntas.ContentSize = new CGSize(scvScrollSalasJuntas.Frame.Width, scvScrollSalasJuntas.Frame.Height);
            Console.WriteLine(scvScrollSalasJuntas.ContentSize);
            nfloat with = 0;
            nfloat ImageX = 0;
            for (int i = 0; i < n; i++)
            {
                imgSalaJuntas.Frame = new CGRect(ImageX, imgSalaJuntas.Frame.Y, imgSalaJuntas.Frame.Width, imgSalaJuntas.Frame.Height);
                imgSalaJuntas.Image = UIImage.FromBundle("ImagenSala");
               
                //scvScrollSalasJuntas.AddSubview(imgSalaJuntas);
                with = with + imgSalaJuntas.Frame.Width;
                ImageX = ImageX + imgSalaJuntas.Frame.Width;

            }
            this.scvScrollSalasJuntas.ContentSize = new CGSize(with, scvScrollSalasJuntas.Frame.Height);
            //this.scvScrollSalasJuntas.Frame = new CGRect(this.scvScrollSalasJuntas.Frame.X, this.scvScrollSalasJuntas.Frame.Y, with, this.scvScrollSalasJuntas.Frame.Height);
            //this.vwVistaSalas.Frame = new CGRect(this.vwVistaSalas.Frame.X, this.vwVistaSalas.Frame.Y, with, this.vwVistaSalas.Frame.Height);
            scvScrollSalasJuntas.AddSubview(this.vwVistaSalas);
            //this.scvScrollSalasJuntas.ContentSize = new CGSize(with, scvScrollSalasJuntas.Frame.Height + 10);
            Console.WriteLine(scvScrollSalasJuntas.ContentSize);*/
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