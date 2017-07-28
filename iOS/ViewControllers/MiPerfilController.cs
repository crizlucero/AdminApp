using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.iOS.Styles;
using PerpetualEngine.Storage;

namespace WorklabsMx.iOS
{
    public partial class MiPerfilController : UITableViewController
    {
        UITableView table;
        public MiPerfilController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{

			base.ViewDidLoad();
			table = new UITableView(View.Bounds);
			List<ItemsMenu> tableItems = new List<ItemsMenu>();
            var localStorage = SimpleStorage.EditGroup("Menu");
            foreach (ItemsMenu menu in new WorklabsMx.Controllers.EscritorioController().GetMenu(localStorage.Get("Menu_Id")))
			{
				tableItems.Add(menu);
			}
			

			table.Source = new STLTableViewSource(tableItems, this);
			Add(table);
		}

        public void FillCampos(){
            
        }
    }
}