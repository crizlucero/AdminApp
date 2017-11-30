using Foundation;
using System;
using UIKit;
//using Softweb.Xamarin.Controls.iOS;
using WorklabsMx.Models;
using CoreGraphics;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using WorklabsMx.iOS.ViewElements;

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

           /* //Create required objects
            var calendar = new Calendar();
            var menuView = new CalendarMenuView
            { Frame = new CGRect(0f, 0f, 320f, 40f) };
            var contentView = new CalendarContentView
            { Frame = new CGRect(0f, 45f, 320f, 280f) };

            //Customize calendar's appearance
            var appearance = calendar.CalendarAppearance;
            appearance.GetNSCalendar().FirstWeekDay = (nuint)3;
            appearance.DayCircleColorSelected = UIColor.LightGray;
            appearance.DayCircleRatio = (9f / 10f);
            appearance.WeekDayFormat = CalendarWeekDayFormat.Single;

            //Link the views to the calendar
            calendar.MenuMonthsView = menuView;
            calendar.ContentView = contentView;

            calendar.DateSelected += DateSelected;
            calendar.NextPageLoaded += DidLoadNextPage;
            calendar.PreviousPageLoaded += DidLoadPreviousPage;

            // Pass a function that returns text to display in month label
            //E.g. "JAN 2014" OR “01/2014"
            appearance.SetMonthLabelTextCallback(
                //Full month-name and year. E.g. DECEMBER 2014
                (NSDate date, Calendar cal) => new NSString(
                    ((DateTime)date).ToString("MMMM yyyy")));

            //Add the views to the current view
            View.Add(menuView);
            View.Add(contentView);*/
        }

        /*public void DateSelected(object sender, DateSelectedEventArgs args)
        {
            Console.WriteLine(String.Format("Selected date is {0}", ((DateTime)args.Date).ToLocalTime().ToString("dd-MMM-yyyy")));
        }

        public void DidLoadPreviousPage(object sender, EventArgs args)
        {
            Console.WriteLine("Loaded previous page");
        }

        public void DidLoadNextPage(object sender, EventArgs args)
        {
            Console.WriteLine("Loaded next page");
        }*/

        partial void btnEditar_TouchUpInside(UIButton sender)
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
            this.lblSucursal.Text = Sucursal;
        }
    }
}