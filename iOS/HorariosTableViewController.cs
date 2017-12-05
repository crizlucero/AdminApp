using System;
using UIKit;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class HorariosTableViewController : UITableViewController
    {

        List<String> Horarios = new List<string>();
        int TamañoCelda = 30;
        const string identificadorCeld = "Horarios";

        public HorariosTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            this.TableView.AllowsMultipleSelectionDuringEditing = true;
            TableView.SetEditing(true, false);
            Horarios.Add("1:00 a.m");
            Horarios.Add("2:00 a.m");
            Horarios.Add("3:00 a.m");
            Horarios.Add("4:00 a.m");
            Horarios.Add("5:00 a.m");
            Horarios.Add("6:00 a.m");
            Horarios.Add("7:00 a.m");
            Horarios.Add("8:00 a.m");
            Horarios.Add("9:00 a.m");
            Horarios.Add("10:00 a.m");
            Horarios.Add("11:00 a.m");
            Horarios.Add("12:00 a.m");

            Horarios.Add("1:00 p.m");
            Horarios.Add("2:00 p.m");
            Horarios.Add("3:00 p.m");
            Horarios.Add("4:00 p.m");
            Horarios.Add("5:00 p.m");
            Horarios.Add("6:00 p.m");
            Horarios.Add("7:00 p.m");
            Horarios.Add("8:00 p.m");
            Horarios.Add("9:00 p.m");
            Horarios.Add("10:00 p.m");
            Horarios.Add("11:00 p.m");
            Horarios.Add("12:00 p.m");
        }

        public override void ViewWillAppear(bool animated)
        {
            
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return Horarios.Count;
        }       


        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            return TamañoCelda;
        }


        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            var Horario = Horarios[indexPath.Row];
            var currentPostCell = (HorariosTableViewCell)tableView.DequeueReusableCell(identificadorCeld);
            currentPostCell.UpdateCell(Horario);
            return currentPostCell;
        }

    }
}