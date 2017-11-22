using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class TelefoniaTableView : UITableViewController
    {
        const string IdentificadorCeldaInfo = "Info";
        const string IdentificadorCeldaNoInfo = "NoInfo";


        const int TamañoCeldaInfo = 70;
        const int TamañoMensajeNoInfo = 400;

        bool isShowInformation = false;
        bool existeConeccion = true;


        public TelefoniaTableView(IntPtr handle) : base (handle)
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