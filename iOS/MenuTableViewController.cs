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
   
        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Contenido";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoCelda = 46;
        const int TamañoHeader = 120;
        const int TamañoMensajeNoInfo = 800;

        bool isShowInformation = false;
        bool existeConeccion = true;

       int SubmenuIndex = 0;
        public static List<ItemsMenu> tableItems;

        public MenuTableViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            tableItems = MenuHelper.GeneralList;
            //await MenuHelper.FillData();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
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
            if (tableItems.Count > 0)
            {
                isShowInformation = true;
                return tableItems.Count;
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
                var current = tableItems[indexPath.Row];
                var currentOptionCell = (MenuContenidoCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
                currentOptionCell.UpdateCell(current.Label);
                return currentOptionCell;
            }
            else
            {
                var noPostCell = (NoInfoMenuCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }

        }

        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                this.PerformSegue("ToSocial", this);
            }
            else if (indexPath.Row == 1)
            {
                this.PerformSegue("Directorio", null);
            }
            /*else if (indexPath.Row == 2)
            {
                this.PerformSegue("Servicios", null);
            }*/
            else if (indexPath.Row == 2)
            {
                this.PerformSegue("ReservarSalaJuntas", this);
            }
            else if (indexPath.Row == 3)
            {
                this.PerformSegue("RegistroInvitados", null);
            }
            else if (indexPath.Row == 4)
            {
                this.PerformSegue("scanQR", null);
            }
            else if (indexPath.Row == 5)
            {
                 this.CerrarSesion();
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
            await Task.Delay(1000);
            BTProgressHUD.Show(status: "Cerrando sesión");
            KeyChainHelper.DeleteKey("Usuario_Id");
            KeyChainHelper.DeleteKey("Usuario_Tipo");
            KeyChainHelper.DeleteKey("Empresa_Id");
            KeyChainHelper.DeleteKey("Colaborador_Id");
            KeyChainHelper.DeleteKey("Menu_Id");
            var app = (AppDelegate)UIApplication.SharedApplication.Delegate;
            app.Window.RootViewController = UIStoryboard.FromName("Main", null).InstantiateViewController("LoginViewController") as UIViewController;
            BTProgressHUD.Dismiss();
        }


    }

}