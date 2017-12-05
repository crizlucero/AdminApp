using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Styles;
using WorklabsMx.iOS.Helpers;

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
            //var localStorage = PerpetualEngine.Storage.SimpleStorage.EditGroup("Menu");
            //var loginStorage = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");

            foreach (ItemsMenu submenu in new Controllers.EscritorioController().GetMenuiOS(Convert.ToInt32(KeyChainHelper.GetKey("Usuario_Tipo")), KeyChainHelper.GetKey("Menu_Id")))
            {
                tableItems.Add(submenu);
            }
            table.Source = new STLTableViewSource(tableItems, this);
            Add(table);
        }
    }
}