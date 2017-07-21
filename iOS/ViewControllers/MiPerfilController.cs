using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.iOS.Helpers;

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
			tableItems.Add(new ItemsMenu { Image = "ic_label", Label = "Registro de Invitados", Controller = "RegistroInvitadosController" });

			table.Source = new TableSource(tableItems, this);
			Add(table);
		}

        public void FillCampos(){
            
        }
    }
}