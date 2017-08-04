using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class TableViewController : UITableViewController
    {
        UITableView table;
        public TableViewController(IntPtr handle) : base(handle)
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            table = new UITableView(View.Bounds);
            List<ItemsMenu> tableItems = new List<ItemsMenu>();
            var localStorage = SimpleStorage.EditGroup("Login");
            Dictionary<string, string> data = new MiembrosController().GetMemberName(localStorage.Get("Miembro_Id"));
            tableItems.Add(new ItemsMenu { Image = "http://desarrolloworklabs.com/Dashboard_Client/usr_imgs/" + data["Fotografia"], Label = data["Nombre"], Principal = true });
            foreach (ItemsMenu menu in new WorklabsMx.Controllers.EscritorioController().GetMenu())
            {
                tableItems.Add(menu);
            }
            table.Source = new STLTableViewSource(tableItems, this);
            Add(table);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}