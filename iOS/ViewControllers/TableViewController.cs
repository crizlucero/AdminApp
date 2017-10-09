using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Helpers;

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
            List<string> data = new MiembrosController().GetMemberName(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
            try
            {
                tableItems.Add(new ItemsMenu { Image = "http://desarrolloworklabs.com/Dashboard_Client/usr_imgs/" + data[2], Label = data[1], Principal = true });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            foreach (ItemsMenu menu in new Controllers.EscritorioController().GetMenuiOS(Convert.ToInt32(localStorage.Get("Usuario_Tipo"))))
            {
                tableItems.Add(menu);
            }
            table.Source = new STLTableViewSource(tableItems, this);
            Add(table);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}