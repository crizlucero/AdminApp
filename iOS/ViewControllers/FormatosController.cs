using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Styles;
using PerpetualEngine.Storage;

namespace WorklabsMx.iOS
{
    public partial class FormatosController : UITableViewController
    {
        UITableView table;
        public FormatosController (IntPtr handle) : base (handle)
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
			//tableItems.Add(new ItemsMenu { Image = "ic_label", Label = "Reservar Sala de Juntas" });
            //tableItems.Add(new ItemsMenu { Image = "ic_label", Label = "Registro de Invitados", Controller="RegistroInvitadosController" });

			table.Source = new STLTableViewSource(tableItems, this);
			Add(table);
		}
    }
}