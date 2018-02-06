using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.iOS.Helpers;
using BigTed;
using SWRevealViewControllerBinding;
using Foundation;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class MenuTableViewController : UITableViewController
    {
   
       int SubmenuIndex = 0;

        List<ItemsMenu> tableItems = new List<ItemsMenu>();

        public MenuTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override  async void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            tableItems = new List<ItemsMenu>();
            await FillTable();
            this.TableView.Source = new EgTableViewSource(tableItems, this);
            BTProgressHUD.Dismiss();
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        void RowSelected(NSIndexPath indexPath)
        {
            
        }

        async Task FillTable()
        {
            await Task.Delay(50);
            foreach (ItemsMenu menu in new Controllers.EscritorioController().GetMenuiOS(Convert.ToInt32(KeyChainHelper.GetKey("Usuario_Tipo"))))
            {
                if (menu.Menu_Id != "22" && menu.Menu_Id != "8")
                {
                    TableView.BeginUpdates();
                    tableItems.Add(menu);
                    TableView.EndUpdates();
                }

            }
        }

 
       
        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            if (segue.Identifier == "MiCuenta")
            {
                var submenuView = segue.DestinationViewController.ChildViewControllers[0] as SubMenuController;
                submenuView.SubmenuIndex = this.SubmenuIndex;
            }
            var segueReveal = segue as SWRevealViewControllerSegueSetController;
            if (segueReveal == null)
            {
                return;
            }

            this.RevealViewController().PushFrontViewController(segueReveal.DestinationViewController, true);
        }

        public async void CerrarSesion()
        {
            BTProgressHUD.Show(status: "Cerrando sesión");
            await Task.Delay(50);
            KeyChainHelper.DeleteKey("Usuario_Id");
            KeyChainHelper.DeleteKey("Usuario_Tipo");
            KeyChainHelper.DeleteKey("Empresa_Id");
            KeyChainHelper.DeleteKey("Colaborador_Id");
            KeyChainHelper.DeleteKey("Menu_Id");

            var controller = UIStoryboard.FromName("Main", null)
                .InstantiateViewController("LoginViewController");
            controller.Title = "Iniciar Sesión";
            BTProgressHUD.Dismiss();
            UIApplication.SharedApplication.Windows[0].RootViewController = controller;
        }


    }


    public class EgTableViewSource : UITableViewSource
    {
        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Contenido";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoCelda = 46;
        const int TamañoHeader = 120;
        const int TamañoMensajeNoInfo = 800;

        bool isShowInformation = false;
        bool existeConeccion = true;


        List<ItemsMenu> TableItems = new List<ItemsMenu>();
        MenuTableViewController Controller;

        public EgTableViewSource(List<ItemsMenu> tableItems, MenuTableViewController Controller)
        {
            TableItems = tableItems;
            this.Controller = Controller;
        }


        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (HeaderMenulCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell();
            return headerCell;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (TableItems.Count > 0)
            {
                isShowInformation = true;
                return TableItems.Count;
            }
            isShowInformation = false;
            return 1;
        }


        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                return TamañoCelda;
            }
            else
            {
                return TamañoMensajeNoInfo;
            }
        }


        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var current = TableItems[indexPath.Row];
                var currentOptionCell = (MenuContenidoCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
                currentOptionCell.UpdateCell(current.Label);
                BTProgressHUD.Dismiss();
                //tableView.ReloadRows(new[] {indexPath}, UITableViewRowAnimation.Fade);
                return currentOptionCell;
            }
            else
            {
                BTProgressHUD.Dismiss();
                var noPostCell = (NoInfoMenuCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }

        }

        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                this.Controller.PerformSegue("ToSocial", this);
            }
            else if (indexPath.Row == 1)
            {
                this.Controller.PerformSegue("Directorio", null);
            }
            else if (indexPath.Row == 2)
            {
                this.Controller.PerformSegue("ReservarSalaJuntas", this);
            }
            else if (indexPath.Row == 3)
            {
                this.Controller.PerformSegue("RegistroInvitados", null);
            }
            else if (indexPath.Row == 4)
            {
                this.Controller.PerformSegue("scanQR", null);
            }
            else if (indexPath.Row == 5)
            {
                this.Controller.CerrarSesion();
            }

        }

        public override void WillDisplay(UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
        {
           
        }
    }
}