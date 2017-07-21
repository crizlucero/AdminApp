using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx;

namespace WorklabsMx.iOS.Helpers
{
    public class TableSource : UITableViewSource
    {

        internal List<ItemsMenu> TableItems;
        string CellIdentifier = "TableCell";
        UITableViewController owner;
        public TableSource(List<ItemsMenu> items, UITableViewController owner)
        {
            this.TableItems = items;
            this.owner = owner;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = TableItems[indexPath.Row].Label;
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            cell.TextLabel.Text = item;
            if (!TableItems[indexPath.Row].Principal)
                cell.ImageView.Image = UIImage.FromBundle(TableItems[indexPath.Row].Image);
            else
            {
                using (var url = new NSUrl(TableItems[indexPath.Row].Image))
                {
                    using (var data = NSData.FromUrl(url))
                    {
                        if (data != null)
                            cell.ImageView.Image = UIImage.LoadFromData(data);
                    }
                }
            }
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            if (TableItems[indexPath.Row].Controller != null)
            {
                UIViewController controller = owner.Storyboard.InstantiateViewController(TableItems[indexPath.Row].Controller);
                controller.Title = TableItems[indexPath.Row].Label;
                owner.NavigationController.PushViewController(controller, true);
            }
        }
    }
}
