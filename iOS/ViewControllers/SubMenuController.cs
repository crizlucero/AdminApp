using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class SubMenuController : UITableViewController
    {
        UITableView table;
        public SubMenuController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {

            base.ViewDidLoad();
            table = new UITableView(View.Bounds);
            List<ItemsMenu> tableItems = new List<ItemsMenu>();
            var localStorage = PerpetualEngine.Storage.SimpleStorage.EditGroup("Menu");
            foreach (ItemsMenu menu in new WorklabsMx.Controllers.EscritorioController().GetMenu(localStorage.Get("Menu_Id")))
            {
                tableItems.Add(menu);
            }


            table.Source = new STLTableViewSource(tableItems, this);
            Add(table);
        }
    }
}