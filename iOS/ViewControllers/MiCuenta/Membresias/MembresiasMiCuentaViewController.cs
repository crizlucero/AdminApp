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
    public partial class MembresiasMiCuentaViewController : UITableViewController
    {
        const string IdentificadorCeldaInfo = "Info";
        const string IdentificadorCeldaNoInfo = "NoInfo";


        const int TamañoCeldaInfo = 150;
        const int TamañoMensajeNoInfo = 600;

        bool isShowInformation = false;
        bool existeConeccion = true;

        public List<CarritoComprasDetalle> allMembers = new List<CarritoComprasDetalle>();

        public MembresiasMiCuentaViewController(IntPtr handle) : base (handle)
        {

        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            if (InternetConectionHelper.VerificarConexion())
            {
                //Cargar allMembers
            }
            else
            {
                isShowInformation = false;
                existeConeccion = false;
            }

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (allMembers.Count > 0)
            {
                isShowInformation = true;
                return allMembers.Count;
            }
            isShowInformation = false;
            return 1;
        }

        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                return TamañoCeldaInfo;
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
                var currentProduct = allMembers[indexPath.Row];
                var currentProductCell = (CuentaMembresiasCell)tableView.DequeueReusableCell(IdentificadorCeldaInfo, indexPath);
                currentProductCell.UpdateCell(currentProduct);
                this.WillDisplay(indexPath.Row);
                return currentProductCell;
            }
            else
            {
                BTProgressHUD.Dismiss();
                var noPostCell = (NoInfoCuentaMembresiasCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }

        private void WillDisplay(int Row)
        {
            int LastRow = allMembers.Count - 1;
            if (Row == LastRow)
            {
                BTProgressHUD.Dismiss();
            }
        }

    }
}