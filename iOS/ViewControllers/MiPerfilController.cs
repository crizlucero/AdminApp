using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.iOS.Styles;

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
			tableItems.Add(new ItemsMenu { Image = "ic_label", Label = "Mis Datos", Controller = "PerfilController"  });
            tableItems.Add(new ItemsMenu { Image = "ic_label", Label = "Datos de Facturación" });
            tableItems.Add(new ItemsMenu { Image = "ic_label", Label = "Equipo de Trabajo", Controller = "MisColaboradoresController" });

			table.Source = new STLTableViewSource(tableItems, this);
			Add(table);
		}

        public void FillCampos(){
            
        }
    }
}