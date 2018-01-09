using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using BigTed;

namespace WorklabsMx.iOS
{
    public partial class EmpresasTableViewController : UITableViewController
    {

        List<EmpresaModel> Empresas = new List<EmpresaModel>();

        const string IdentificadorCeldaHeader = "HeaderBuscador";
        const string IdentificadorCeldaUsuarios = "CeldaEmpresas";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoUsuarios = 70;
        const int TamañoHeader = 50;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        const int TamañoMensajeNoInfo = 800;

        bool isShowInformation = false;
        bool existeConeccion = true;

        public EmpresasTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.FillData();
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
        }

        private void FillData(string nombre = "", string giro = "", string pais = "", string estado = "", string municipio = "")
        {
            this.Empresas = new EmpresaController().GetDirectorioEmpresas(nombre, pais, estado, municipio, giro);

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (HeaderEmpresasCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell();
            return headerCell.ContentView;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (this.Empresas.Count > 0)
            {
                isShowInformation = true;
                return this.Empresas.Count;
            }
            isShowInformation = false;
            return 1;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var current = Empresas[indexPath.Row];
                var currentUser = (CeldaEmpresasCell)tableView.DequeueReusableCell(IdentificadorCeldaUsuarios, indexPath);
                currentUser.UpdateCell(current);
                this.WillDisplay(indexPath.Row);
                return currentUser;
            }
            else
            {
                BTProgressHUD.Dismiss();
                var noPostCell = (NoInfoEmpresas)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }


        private void WillDisplay(int Row)
        {
            int LastRow = Empresas.Count - 1;
            if ((Row == LastRow))
            {
                BTProgressHUD.Dismiss();
            }
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "DetallarPerfil")
            {
                var PerfilView = (PerfilesTableViewController)segue.DestinationViewController;
                //PerfilView.ListUser = ListUser;
            }
        }



    }
}