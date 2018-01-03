using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using BigTed;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class FavoritosTableViewController : UITableViewController
    {
        MiembrosController Favorites = new MiembrosController();
        List<MiembroModel> Usuarios = new List<MiembroModel>();
        List<MiembroModel> UsuariosFavoritos = new List<MiembroModel>();

        const string IdentificadorCeldaHeader = "HeaderBuscador";
        const string IdentificadorCeldaUsuarios = "CeldaFavoritos";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoUsuarios = 70;
        const int TamañoHeader = 50;
        const int TamañoMensajeNoInfo = 800;

        bool isShowInformation = false;
        bool existeConeccion = true;

        public FavoritosTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.FillData();
        }

        public override void ViewWillAppear(bool animated)
        {
           
        }

        private void FillData(string nombre = "", string apellido = "", string puesto = "", string profesion = "", string habilidades = "", bool disponibilidad = true, string pais = "", string estado = "", string municipio = "")
        {
            this.Usuarios = new MiembrosController().GetDirectorioUsuarios(nombre, apellido, puesto, profesion, habilidades, disponibilidad, pais, estado, municipio);
            foreach(MiembroModel UsuarioFavorito in this.Usuarios)
            {
                var isFavorite = Favorites.IsMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), UsuarioFavorito.Miembro_Id, UsuarioFavorito.Miembro_Tipo);
                if(isFavorite.Value)
                {
                    this.UsuariosFavoritos.Add(UsuarioFavorito);
                }
            }
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (HeaderFavoritosTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            return headerCell;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (this.UsuariosFavoritos.Count > 0)
            {
                isShowInformation = true;
                return this.UsuariosFavoritos.Count;
            }
            isShowInformation = false;
            return 1;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var current = UsuariosFavoritos[indexPath.Row];
                var currentUser = (FavoritosTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaUsuarios, indexPath);
                currentUser.UpdateCell(current);
                this.WillDisplay(indexPath.Row);
                return currentUser;
            }
            else
            {
                BTProgressHUD.Dismiss();
                var noPostCell = (FavoritosNoInfo)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
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