using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using BigTed;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Models;

namespace WorklabsMx.iOS
{
    public partial class TableViewMembresia : UITableViewController
    {
        const int TamañoRowMembresias = 512;
        const int TamañoRowNoMembresias = 329;

        const string IDENTIFICADOR_CELDA_MEMBRESIAS = "membresias";
        const string IDENTIFICADOR_CELDA_NO_MEMBRESIAS = "no_membresias";

        bool isShowInformation = false;
        bool existeConeccion = true;

        //readonly Dictionary<string, CarritoModel> Carrito;
        List<MembresiaModel> Membresias;

        List<Array> arreglo;

        public TableViewMembresia (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var barViewControllers = this.TabBarController.ViewControllers;
            var svc = (CarritoProductos)barViewControllers[0]; //20
            var total = svc.getTotalPagar();
            BTProgressHUD.Show();

            if (InternetConectionHelper.VerificarConexion())
            {
                Membresias = new PickerItemsController().GetMembresias();
               
            }
            else
            {
                isShowInformation = false;
                existeConeccion = false;
            }
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (Membresias.Count > 0)
            {
                isShowInformation = true;
                return Membresias.Count;
            }
            isShowInformation = false;
            return 1;
        }

        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                return TamañoRowMembresias;
            }
            else
            {
                return TamañoRowNoMembresias;
            }
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var currentMembership = Membresias[indexPath.Row];
                var currentMembershipCell = (TableViewCellMembresias)tableView.DequeueReusableCell(IDENTIFICADOR_CELDA_MEMBRESIAS, indexPath);
                currentMembershipCell.UpdateCell(currentMembership);
                this.WillDisplay(indexPath.Row);
                return currentMembershipCell;
            }
            else
            {
                BTProgressHUD.Dismiss();
                var noPostCell = (TableViewCellNoMembresias)tableView.DequeueReusableCell(IDENTIFICADOR_CELDA_NO_MEMBRESIAS, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }

        private void WillDisplay(int Row)
        {
            int LastRow = Membresias.Count - 1;
            if (Row == LastRow)
            {
                BTProgressHUD.Dismiss();
            }
        }

    }
}