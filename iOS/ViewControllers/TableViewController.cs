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
            tableItems.Add(new ItemsMenu { Image = "http://desarrolloworklabs.com/Dashboard_Client/" + data["Fotografia"], Label = data["Nombre"], Principal = true });
            tableItems.Add(new ItemsMenu { Image = "ic_dashboard", Label = "Escritorio", Principal = false, Controller = "EscritorioController" });
            tableItems.Add(new ItemsMenu { Image = "ic_call", Label = "Telefonía", Principal = false });
            tableItems.Add(new ItemsMenu { Image = "ic_cloud", Label = "Cloud", Principal = false });
            tableItems.Add(new ItemsMenu { Image = "ic_description", Label = "Facturación", Principal = false });
            tableItems.Add(new ItemsMenu { Image = "ic_credit_card", Label = "Pagos", Principal = false });
            tableItems.Add(new ItemsMenu { Image = "ic_create", Label = "Formatos", Principal = false, Controller = "FormatosController" });
            tableItems.Add(new ItemsMenu { Image = "ic_format_list_bulleted", Label = "Servicios", Principal = false, Controller = "ServiciosController" });
            tableItems.Add(new ItemsMenu { Image = "ic_person", Label = "Mi Perfil", Principal = false, Controller = "MiPerfilController" });
            tableItems.Add(new ItemsMenu { Image = "ic_book", Label = "Directorio", Principal = false, Controller = "DirectorioController" });

            table.Source = new STLTableViewSource(tableItems, this);
            Add(table);
        }

        public static explicit operator TableViewController(FormatosController v)
        {
            throw new NotImplementedException();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}