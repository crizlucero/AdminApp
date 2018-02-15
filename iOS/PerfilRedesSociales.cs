using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class PerfilRedesSociales : UITableViewController
    {

        const string IdentificadorContenido = "Contenido";
        const string IdentificadorNoRedes = "NoRedes";

        const int TamañoCelda = 40;
        const int TamañoCeldaNoRedes = 400;

        bool isShowInformation = false;
        bool existeConeccion = true;

        public List<RedSocialModel> Redes_Sociales;

        public PerfilRedesSociales (IntPtr handle) : base (handle)
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


        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (Redes_Sociales.Count > 0)
            {
                isShowInformation = true;
                return Redes_Sociales.Count;
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
            return TamañoCeldaNoRedes;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var currentSocial = Redes_Sociales[indexPath.Row];
                var currentCell = (RedesSocialesTableViewCell)tableView.DequeueReusableCell(IdentificadorContenido, indexPath);
                currentCell.UpdateCell(currentSocial);
                return currentCell;
            }
            else
            {
                var currentCell = tableView.DequeueReusableCell(IdentificadorNoRedes, indexPath);
                return currentCell;
            }

        }

    }
}