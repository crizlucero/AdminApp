using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
//using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.iOS.Helpers;
using BigTed;
using SWRevealViewControllerBinding;

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

        List<ItemsMenu> tableItems = new List<ItemsMenu>();

        public MenuTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
           
            List<string> data = new MiembrosController().GetMemberName(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
            try
            {
                //tableItems.Add(new ItemsMenu { Image = "http://desarrolloworklabs.com/Dashboard_Client/usr_imgs/" + data[(int)CamposMiembro.Usuario_Fotografia], Label = data[(int)CamposMiembro.Usuario_Nombre], Principal = true });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            foreach (ItemsMenu menu in new Controllers.EscritorioController().GetMenuiOS(Convert.ToInt32(KeyChainHelper.GetKey("Usuario_Tipo"))))
            {
                tableItems.Add(menu);
            }
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
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

        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                this.PerformSegue("ToSocial", this);
            }
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var current = tableItems[indexPath.Row];
                var currentOptionCell = (MenuContenidoCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
                currentOptionCell.UpdateCell(current.Label);
                this.WillDisplay(indexPath.Row);
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

        private void WillDisplay(int Row)
        {
            int LastRow = tableItems.Count - 1;
            if ((Row == LastRow))
            {
                BTProgressHUD.Dismiss();
            }
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            var segueReveal = segue as SWRevealViewControllerSegueSetController;
            if (segueReveal == null)
            {
                return;
            }
            this.RevealViewController().PushFrontViewController(segueReveal.DestinationViewController, true);
        }



    }
}