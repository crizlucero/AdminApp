using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.Models;
using EventKit;
using EventKitUI;
using System.Linq;
using MonoTouch.Dialog;


namespace WorklabsMx.iOS
{
    public partial class ReservacionesTableView : UITableViewController
    {

        public SalaJuntasReservacionModel Reservaciones = new SalaJuntasReservacionModel();

        const string IdentificadorReservaciones = "Reservaciones";

        const int TamañoReservaciones = 117;


        public ReservacionesTableView (IntPtr handle) : base (handle)
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


        public override nint RowsInSection(UITableView tableView, nint section)
        {
           return 1;
        }


        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            var current = Reservaciones;
            var currentPostCell = (ReservacionTableViewCell)tableView.DequeueReusableCell(IdentificadorReservaciones, indexPath);
            currentPostCell.UpdateCell(current);
            return currentPostCell;
           
        }



    }
}