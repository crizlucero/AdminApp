using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using BigTed;
using WorklabsMx.iOS.Helpers;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class FavoritosTableViewController : UITableViewController
    {
        UsuariosController Favorites = new UsuariosController();
        List<UsuarioModel> Usuarios = new List<UsuarioModel>();
        List<UsuarioModel> UsuariosFavoritos = new List<UsuarioModel>();

        const string IdentificadorCeldaHeader = "HeaderBuscador";
        const string IdentificadorCeldaUsuarios = "CeldaFavoritos";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoUsuarios = 70;
        const int TamañoHeader = 50;
        const int TamañoMensajeNoInfo = 500;

        bool isShowInformation = false;
        bool existeConeccion = true;

        List<string> ListUser = new List<string>();

        public FavoritosTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            UsuariosFavoritos = new List<UsuarioModel>();
            RefreshControl = new UIRefreshControl();
            RefreshControl.AddTarget(HandleValueChanged, UIControlEvent.ValueChanged);
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
            await FillData();
            this.TableView.ReloadData();
            TableView.BeginUpdates();
            TableView.EndUpdates();
        }

        public  override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            UsuariosFavoritos = new List<UsuarioModel>();
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                return TamañoUsuarios;
            }
            return TamañoMensajeNoInfo;
        }


        async Task FillData(string nombre = "", string apellido = "", string puesto = "", string profesion = "", string habilidades = "", bool disponibilidad = true, string pais = "", string estado = "", string municipio = "")
        {
            await Task.Run(() =>
            {
                this.Usuarios = new UsuariosController().GetDirectorioUsuarios(nombre, apellido, puesto, profesion, habilidades, disponibilidad, pais, estado, municipio);
                foreach (UsuarioModel UsuarioFavorito in this.Usuarios)
                {
                    var isFavorite = Favorites.IsMiembroFavorito(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), UsuarioFavorito.Usuario_Id, UsuarioFavorito.Usuario_Tipo);
                    if (isFavorite.Value)
                    {
                        this.UsuariosFavoritos.Add(UsuarioFavorito);
                    }
                }
            });
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (HeaderFavoritosTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.EventosBuscarDelegate = this;
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
                tableView.BeginUpdates();
                var current = UsuariosFavoritos[indexPath.Row];
                var currentUser = (FavoritosTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaUsuarios, indexPath);
                currentUser.EventosFavoritosCellDelegate = this;
                currentUser.UpdateCell(current);
                tableView.EndUpdates();
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


        void HandleValueChanged(object sender, EventArgs e)
        {
            this.GetData();
        }

        async void GetData()
        {
            RefreshControl.BeginRefreshing();
            await FillData();
            TableView.ReloadData();
            TableView.BeginUpdates();
            TableView.EndUpdates();
            if (RefreshControl != null && RefreshControl.Refreshing)
                RefreshControl.EndRefreshing();

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

    public partial class FavoritosTableViewController : EventosFavoritosCell
    {
        public void InfoUserPost(List<String> listaUser)
        {
            ListUser = listaUser;
            //this.PerformSegue("DetallarPerfil", null);
        }

    }

    public partial class FavoritosTableViewController : EventosBuscar
    {
        public async void Buscando(string SearchText)
        {
            await Task.Delay(50);
            string TextoBuscar = SearchText;
            List<UsuarioModel> SearchPost = new List<UsuarioModel>();

            if (InternetConectionHelper.VerificarConexion())
            {
                await FillData();
            }

            if (TextoBuscar != "")
            {
                if (UsuariosFavoritos.FindAll(x => x.Usuario_Nombre.Contains(TextoBuscar)) != null)
                {
                    foreach (UsuarioModel post in UsuariosFavoritos.FindAll(x => x.Usuario_Nombre.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (UsuariosFavoritos.FindAll(x => x.Usuario_Apellidos.Contains(TextoBuscar)) != null)
                {
                    foreach (UsuarioModel post in UsuariosFavoritos.FindAll(x => x.Usuario_Apellidos.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (UsuariosFavoritos.FindAll(x => x.Usuario_Puesto.Contains(TextoBuscar)) != null)
                {
                    foreach (UsuarioModel post in UsuariosFavoritos.FindAll(x => x.Usuario_Puesto.Contains(TextoBuscar)))
                    {
                        if (SearchPost.Contains(post) == false)
                        {
                            SearchPost.Add(post);
                        }

                    }
                }
                if (UsuariosFavoritos.FindAll(x => x.Usuario_Profesion.Contains(TextoBuscar)) != null)
                {
                    foreach (UsuarioModel post in UsuariosFavoritos.FindAll(x => x.Usuario_Profesion.Contains(TextoBuscar)))
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
    }
}