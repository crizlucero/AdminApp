using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace WorklabsMx.iOS.Helpers
{
    public class DropDownListSource : UITableViewSource
    {
        internal List<string> TableItems;
        string CellIdentifier = "TableCell";
        readonly UITextField field;
        readonly UITableView selectView;
        public DropDownListSource(List<string> items, UITextField field, UITableView selectView)
        {
            this.TableItems = items;
            this.field = field;
            this.selectView = selectView;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            cell.TextLabel.Text = TableItems[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section) => TableItems.Count;


        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            field.Text = TableItems[indexPath.Row];
            selectView.RemoveFromSuperview();
        }
    }
}
