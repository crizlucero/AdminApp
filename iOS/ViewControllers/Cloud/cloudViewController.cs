using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class cloudViewController : UITableViewController
    {
        
        const string IdentificadorCeldaInfo = "Info";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoCeldaInfo = 70;
        const int TamañoMensajeNoInfo = 600;

        bool isShowInformation = false;
        bool existeConeccion = true;

        public List<ProductoModel> allProducts = new List<ProductoModel>();

        public cloudViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 1;
        }

        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            return TamañoMensajeNoInfo;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            var noPostCell = tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
            return noPostCell;
        }

    }
}