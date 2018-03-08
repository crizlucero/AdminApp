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

        public List<RedSocialModel> Redes_Sociales = new List<RedSocialModel>();
        public List<RedSocialModel> Redes_Sociales_Usuario = new List<RedSocialModel>();

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

            if (Redes_Sociales != null)
            {
                foreach (RedSocialModel RedSocial in Redes_Sociales)
                {
                    if (RedSocial.Red_Social_Enlace != null && RedSocial.Red_Social_Enlace != "")
                    {
                        Redes_Sociales_Usuario.Add(RedSocial);
                    }
                }
            }


        }


        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (Redes_Sociales_Usuario.Count > 0)
            {
                isShowInformation = true;
                return Redes_Sociales_Usuario.Count;
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
                var currentSocial = Redes_Sociales_Usuario[indexPath.Row];
                var currentCell = (RedesSocialesTableViewCell)tableView.DequeueReusableCell(IdentificadorContenido, indexPath);
                currentCell.UpdateCell(currentSocial);
                return currentCell;
            }
            else
            {
                var currentCell = (NoRedesCell)tableView.DequeueReusableCell(IdentificadorNoRedes, indexPath);
                return currentCell;
            }

        }

    }
}