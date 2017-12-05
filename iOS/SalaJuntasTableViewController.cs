using Foundation;
using System;
using UIKit;
//using Factorymind.Components;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class SalaJuntasTableViewController : UITableViewController
    {

        public SalaJuntasTableViewController (IntPtr handle) : base (handle)
        {
            
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            StyleHelper.Style(this.btnComprarHoras.Layer);
            /*FMCalendar fmCalendar = new FMCalendar(this.vwCalendarioJuntas.Bounds);

            this.vwCalendarioJuntas.BackgroundColor = UIColor.White;

            // Specify selection color
            fmCalendar.SelectionColor = UIColor.Red;

            // Specify today circle Color
            fmCalendar.TodayCircleColor = UIColor.Red;

            // Customizing appearance
            fmCalendar.LeftArrow = UIImage.FromFile("leftArrow.png");
            fmCalendar.RightArrow = UIImage.FromFile("rightArrow.png");

            fmCalendar.MonthFormatString = "MMMM yyyy";

            // Shows Sunday as last day of the week
            fmCalendar.SundayFirst = false;

            // Mark with a dot dates that fulfill the predicate
            fmCalendar.IsDayMarkedDelegate = (date) =>
            {
                return date.Day % 2 == 1;
            };

            // Turn gray dates that fulfill the predicate
            fmCalendar.IsDateAvailable = (date) =>
            {
                return (date >= DateTime.Today);
            };

            fmCalendar.MonthChanged = (date) =>
            {
                Console.WriteLine("Month changed {0}", date.Date);
            };

            fmCalendar.DateSelected += (date) =>
            {
                Console.WriteLine("Date selected: {0}", date);
            };

            // Add FMCalendar to SuperView
            fmCalendar.Bounds = this.vwCalendarioJuntas.Bounds;
            //fmCalendar.Center = this.vwCalendarioJuntas.Center;
            this.vwCalendarioJuntas.AddSubview(fmCalendar);*/
        }


        partial void btnComprarHoras_Touch(UIButton sender)
        {
           
        }

        partial void btnEditarSalaJuntas_Touch(UIButton sender)
        {
           
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "MostrarSucursales")
            {
                var SucursalesView = (SucursalesViewController)segue.DestinationViewController;
                SucursalesView.SucursalSeleccionadaDel = this;

            }
        }

    }


    partial class SalaJuntasTableViewController: SucursalSeleccionada
    {
        public void SucursalSeleccionada(string Sucursal)
        {
            this.lblSalaJuntas.Text = Sucursal;
        }
    }
}