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

        int ContadorPerfil;
        List<string> ListUser = new List<string>();

        public FavoritosTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.FillData();
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            ContadorPerfil = 0;
        }

        void Buscando(object sender, EventArgs e)
        {
            string TextoBuscar = sender as string;
            List<MiembroModel> SearchPost = new List<MiembroModel>();

            if (InternetConectionHelper.VerificarConexion())
            {
                this.FillData();
            }

            if (TextoBuscar != "")
            {
                if (UsuariosFavoritos.FindAll(x => x.Miembro_Nombre.Contains(TextoBuscar)) != null)
                {
                    foreach (MiembroModel post in UsuariosFavoritos.FindAll(x => x.Miembro_Nombre.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (UsuariosFavoritos.FindAll(x => x.Miembro_Apellidos.Contains(TextoBuscar)) != null)
                {
                    foreach (MiembroModel post in UsuariosFavoritos.FindAll(x => x.Miembro_Apellidos.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (UsuariosFavoritos.FindAll(x => x.Miembro_Puesto.Contains(TextoBuscar)) != null)
                {
                    foreach (MiembroModel post in UsuariosFavoritos.FindAll(x => x.Miembro_Puesto.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (UsuariosFavoritos.FindAll(x => x.Miembro_Profesion.Contains(TextoBuscar)) != null)
                {
                    foreach (MiembroModel post in UsuariosFavoritos.FindAll(x => x.Miembro_Profesion.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                this.UsuariosFavoritos = SearchPost;
            }
            this.TableView.ReloadData();
        }


        void InfoUserPost(object sender, EventArgs e)
        {
            ContadorPerfil = ContadorPerfil + 1;
            if (ContadorPerfil <= 1)
            {
                ListUser = (List<string>)sender;
                this.PerformSegue("DetallarPerfil", null);
            }

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
            headerCell.Buscando += Buscando;
            headerCell.UpdateCell();
            return headerCell.ContentView;
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
                currentUser.InfoUserPost += InfoUserPost;
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

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "DetallarPerfil")
            {
                var PerfilView = (PerfilesTableViewController)segue.DestinationViewController;
                PerfilView.ListUser = ListUser;
            }
        }


    }
}