using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Styles;
using WorklabsMx.iOS.Helpers;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class SubMenuController : UITableViewController
    {
        UITableView table;

        public int SubmenuIndex = 0;

        public SubMenuController(IntPtr handle) : base(handle)
        {
            
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            table = new UITableView(View.Bounds);
            List<ItemsMenu> tableItems = new List<ItemsMenu>();

            KeyChainHelper.SetKey("Menu_Id", SubmenuIndex.ToString());
            foreach (ItemsMenu submenu in new Controllers.EscritorioController().GetMenuiOS(Convert.ToInt32(KeyChainHelper.GetKey("Usuario_Tipo")), KeyChainHelper.GetKey("Menu_Id")))
            {
                tableItems.Add(submenu);
            }
            table.Source = new STLTableViewSource(tableItems, this);
            Add(table);
        }

        partial void Bakc_Touch(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }
    }
}