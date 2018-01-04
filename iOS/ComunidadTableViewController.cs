using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using BigTed;


namespace WorklabsMx.iOS
{
    public partial class ComunidadTableViewController : UITableViewController
    {
        List<MiembroModel> Usuarios = new List<MiembroModel>();

        const string IdentificadorCeldaHeader = "HeaderBuscador";
        const string IdentificadorCeldaUsuarios = "CeldaUsuarios";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoUsuarios = 70;
        const int TamañoHeader = 50;
        const int TamañoMensajeNoInfo = 800;

        bool isShowInformation = false;
        bool existeConeccion = true;

        UITableViewCell Header = new UITableViewCell();

        public ComunidadTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.FillData();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        private void FillData(string nombre = "", string apellido = "", string puesto = "", string profesion = "", string habilidades = "", bool disponibilidad = true, string pais = "", string estado = "", string municipio = "")
        {
            this.Usuarios = new MiembrosController().GetDirectorioUsuarios(nombre, apellido, puesto, profesion, habilidades, disponibilidad, pais, estado, municipio);
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (BuscadorTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell();
            return headerCell;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (this.Usuarios.Count > 0)
            {
                isShowInformation = true;
                return this.Usuarios.Count;
            }
            isShowInformation = false;
            return 1;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var current = Usuarios[indexPath.Row];
                var currentUser = (ComunidadTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaUsuarios, indexPath);
                currentUser.UpdateCell(current);
                this.WillDisplay(indexPath.Row);
                return currentUser;
            }
            else
            {
                BTProgressHUD.Dismiss();
                var noPostCell = (NoInfoCellUsuarios)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }

        private void WillDisplay(int Row)
        {
            int LastRow = Usuarios.Count - 1;
            if ((Row == LastRow))
            {
                BTProgressHUD.Dismiss();
            }
        }

    }
}