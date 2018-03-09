using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using System.Threading.Tasks;
using Foundation;
using SWRevealViewControllerBinding;
using Xamarin.SimplePing;

namespace WorklabsMx.iOS
{
    public partial class ComunidadTableViewController : UITableViewController
    {
        List<UsuarioModel> Usuarios = new List<UsuarioModel>();
        List<UsuarioModel> UsuariosAux = new List<UsuarioModel>();

        const string IdentificadorCeldaHeader = "HeaderBuscador";
        const string IdentificadorCeldaUsuarios = "CeldaUsuarios";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoUsuarios = 70;
        const int TamañoHeader = 50;
        const int TamañoMensajeNoInfo = 800;

        bool isShowInformation = false;
        bool existeConeccion = true;

        UITableViewCell Header = new UITableViewCell();

        UsuarioModel ListUser = new UsuarioModel();

        public ComunidadTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            BTProgressHUD.Show();
            RefreshControl = new UIRefreshControl();
            RefreshControl.AddTarget(HandleValueChanged, UIControlEvent.ValueChanged);
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);

            BTProgressHUD.Dismiss();
          
        }

        void HandleValueChanged(object sender, EventArgs e)
        {
            this.GetData();
        }

        async void GetData()
        {
            RefreshControl.BeginRefreshing();
            await MenuHelper.FillData();
            Usuarios = MenuHelper.Comunidad;
            TableView.ReloadData();
            TableView.BeginUpdates();
            TableView.EndUpdates();
            if (RefreshControl != null && RefreshControl.Refreshing)
                RefreshControl.EndRefreshing();

        }

        public override async void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            await MenuHelper.FillData();
            Usuarios = MenuHelper.Comunidad;
            this.TableView.ReloadData();
            TableView.BeginUpdates();
            TableView.EndUpdates();
        }


        private void AgregarBusqueda(string Parametro)
        {
            
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if(isShowInformation)
            {
                return TamañoUsuarios;
            }
            return TamañoMensajeNoInfo;
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (BuscadorTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell();
            headerCell.EventoBuscadorDelegate = this;
            return headerCell.ContentView;
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
                tableView.BeginUpdates();
                var current = Usuarios[indexPath.Row];
                var currentUser = (ComunidadTableViewCell)tableView.DequeueReusableCell(IdentificadorCeldaUsuarios, indexPath);
                currentUser.EventosComunidadCellDelegate = this;
                currentUser.UpdateCell(current);
                tableView.EndUpdates();
                return currentUser;
            }
            else
            {
                var noPostCell = (NoInfoCellUsuarios)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
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
                if (MenuHelper.Usuario.Usuario_Id == ListUser.Usuario_Id && MenuHelper.Usuario.Usuario_Tipo == ListUser.Usuario_Tipo)
                {
                    PerfilView.InfoPersonal = true;
                    PerfilView.Miembro = MenuHelper.Usuario;
                }
                else
                {
                    PerfilView.InfoPersonal = false;
                    PerfilView.Miembro = new UsuariosController().GetMemberData(ListUser.Usuario_Id, ListUser.Usuario_Tipo);
                }
            
            }
        }

    }

    partial class ComunidadTableViewController : EventoBuscador
    {
        public async void Buscando(string Texto)
        {
            await Task.Run(() =>
            {
                string TextoBuscar = Texto;
                List<UsuarioModel> SearchPost = new List<UsuarioModel>();

                this.Usuarios = this.UsuariosAux;

                if (TextoBuscar != "")
                {
                    if (Usuarios.FindAll(x => x.Usuario_Nombre.Contains(TextoBuscar)) != null)
                    {
                        foreach (UsuarioModel post in Usuarios.FindAll(x => x.Usuario_Nombre.Contains(TextoBuscar)))
                        {
                            if (SearchPost.Contains(post) == false)
                            {
                                SearchPost.Add(post);
                            }

                        }
                    }
                    if (Usuarios.FindAll(x => x.Usuario_Apellidos.Contains(TextoBuscar)) != null)
                    {
                        foreach (UsuarioModel post in Usuarios.FindAll(x => x.Usuario_Apellidos.Contains(TextoBuscar)))
                        {
                            if (SearchPost.Contains(post) == false)
                            {
                                SearchPost.Add(post);
                            }

                        }
                    }
                    if (Usuarios.FindAll(x => x.Usuario_Puesto.Contains(TextoBuscar)) != null)
                    {
                        foreach (UsuarioModel post in Usuarios.FindAll(x => x.Usuario_Puesto.Contains(TextoBuscar)))
                        {
                            if (SearchPost.Contains(post) == false)
                            {
                                SearchPost.Add(post);
                            }

                        }
                    }
                    if (Usuarios.FindAll(x => x.Usuario_Profesion.Contains(TextoBuscar)) != null)
                    {
                        foreach (UsuarioModel post in Usuarios.FindAll(x => x.Usuario_Profesion.Contains(TextoBuscar)))
                        {
                            if (SearchPost.Contains(post) == false)
                            {
                                SearchPost.Add(post);
                            }

                        }
                    }
                    this.Usuarios = SearchPost;
                }
            });
            this.TableView.ReloadData();
        }
                           
    }

    partial class ComunidadTableViewController : EventosComunidadCell
    {
        public void InfoUserPost(UsuarioModel Miembro)
        {
            ListUser = Miembro;
            this.PerformSegue("DetallarPerfil", null);
        }
    }

}