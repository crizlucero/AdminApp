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

        public static List<ItemsMenu> tableItems = new List<ItemsMenu>();

        public MenuTableViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override async void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            //var headerCell = (HeaderMenulCell)this.TableView.DequeueReusableCell(IdentificadorCeldaHeader);
            //headerCell.UpdateCell();
            tableItems = new List<ItemsMenu>();
            tableItems = MenuHelper.GeneralList;
            TableView.ReloadData();
            await MenuHelper.GetSucursales();
            await MenuHelper.GetMembresias();
            await MenuHelper.GetProductos();
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
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
            if (tableItems != null)
            {
                if (tableItems.Count > 0)
                {
                    isShowInformation = true;
                    return tableItems.Count;
                }
                isShowInformation = false;
                return 1;
            }
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

        public  override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {

            var current = tableItems[indexPath.Row];
            if (current.Controller == "CerrarSesion")
            {
                this.CerrarSesion();
            }
            else
            {
                if(current.Controller != "" && current.Controller != null)
                {
                    this.PerformSegue(current.Controller, this);
                }
            }


            /*if (indexPath.Row == 0)
            {
                this.PerformSegue("ToSocial", this);
            }
            else if (indexPath.Row == 1)
            {
                this.PerformSegue("Directorio", null);
            }
            else if (indexPath.Row == 2)
            {
                this.PerformSegue("Compras", null);
            }
            else if (indexPath.Row == 3)
            { 
                this.PerformSegue("ReservarSalaJuntas", this);
            }
            else if (indexPath.Row == 4)
            {
                this.PerformSegue("RegistroInvitados", null);
            }
            else if (indexPath.Row == 5)
            {
                this.PerformSegue("scanQR", null);
            }
            else if (indexPath.Row == 6)
            {
                this.PerformSegue("AcercaDe", null);
            }
            else if (indexPath.Row == 7)
            {
                 this.CerrarSesion();
            }*/

        }
       
        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "DetallePerfil")
            {
                var PerfilView = (PerfilesTableViewController)segue.DestinationViewController;
                PerfilView.InfoPersonal = true;
                PerfilView.PerfilesDelegate = this;
                PerfilView.Miembro = MenuHelper.Usuario;
                PerfilView.FromMenu = true;
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
    public partial class MenuTableViewController : Perfilesint
    {
        public void InfoActualizar()
        {
            //MenuHelper.GetUsuarioInfo();
            //var headerCell = (HeaderMenulCell)this.TableView.DequeueReusableCell(IdentificadorCeldaHeader);
            //headerCell.UpdateCell();
            TableView.ReloadData();
        }
    }

}