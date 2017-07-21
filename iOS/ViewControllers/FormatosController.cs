using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;

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
			tableItems.Add(new ItemsMenu { Image = "ic_label", Label = "Reservar Sala de Juntas" });
            tableItems.Add(new ItemsMenu { Image = "ic_label", Label = "Registro de Invitados", Controller="RegistroInvitadosController" });

			table.Source = new TableSource(tableItems, this);
			Add(table);
		}
    }
}