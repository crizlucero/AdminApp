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
            var loginStorage = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");

            foreach (ItemsMenu submenu in new Controllers.EscritorioController().GetMenu(Convert.ToInt32(loginStorage.Get("Usuario_Tipo")), localStorage.Get("Menu_Id")))
            {
                tableItems.Add(submenu);
            }
            table.Source = new STLTableViewSource(tableItems, this);
            Add(table);
        }
    }
}